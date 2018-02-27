using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HashCode2018.QualificationRound.WinForm.Drawing;
using HashCode2018.QualificationRound.WinForm.Proccess;

namespace HashCode2018.QualificationRound.WinForm
{
	class MainManager
	{
		public event EventHandler<string> MessageReady;
		public event EventHandler<View> ViewReady;
		private readonly CancellationTokenSource _tokenSource = new CancellationTokenSource();
		private readonly MainProccess _proccess = new MainProccess();

		public MainManager()
		{
			_proccess.MessageWrite = OnMessageReady;
			_proccess.ViewReady = OnViewReady;
		}

		public void Start(string[] lines)
		{
			OnMessageReady("Start proccess");
			var token = _tokenSource.Token;
			Task.Factory.StartNew(() => _proccess.Start(lines, token), token);
			OnMessageReady("Procces started");
		}

		public void Stop()
		{
			_tokenSource.Cancel();
		}

		
		protected virtual void OnMessageReady(string message)
		{
			MessageReady?.Invoke(this, message);
			//_mainForm.Invoke(new DoUpdateMessage(MessageReady?.Invoke));
		}

		protected virtual void OnViewReady(View e)
		{
			ViewReady?.Invoke(this, e);
		}
	}
}
