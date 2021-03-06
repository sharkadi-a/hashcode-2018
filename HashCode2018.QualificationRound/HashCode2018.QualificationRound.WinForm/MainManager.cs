﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HashCode2018.Core;
using HashCode2018.QualificationRound.WinForm.Drawing;
using HashCode2018.QualificationRound.WinForm.Proccess;

namespace HashCode2018.QualificationRound.WinForm
{
	internal class MainManager
	{
		private readonly IProblemSolver _problemSolver;
		public event EventHandler<string> MessageReady;
		public event EventHandler<View> ViewReady;
		private CancellationTokenSource _tokenSource = new CancellationTokenSource();
		private readonly MainProccess _proccess = new MainProccess();

		public MainManager(IProblemSolver problemSolver)
		{
			_problemSolver = problemSolver ?? throw new ArgumentNullException(nameof(problemSolver));
			_problemSolver.SetIterationCallback(OnViewReady);
			_problemSolver.SetLogOutput(OnMessageReady);
		}

		public void Start(InputFile inputFile)
		{
			OnMessageReady("Start proccess");
			var token = _tokenSource.Token;
			_proccess.Start(_problemSolver, inputFile, token);
			OnMessageReady("Procces started");
		}

		public void Stop()
		{
			_tokenSource.Cancel();
			_tokenSource = new CancellationTokenSource();
		}

		
		protected virtual void OnMessageReady(string message)
		{
			MessageReady?.Invoke(this, message);
			//_mainForm.Invoke(new DoUpdateMessage(MessageReady?.Invoke));
		}

		protected virtual void OnViewReady(object e)
		{
			ViewReady?.Invoke(this, (View)e);
		}
	}
}
