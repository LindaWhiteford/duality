﻿using System;

namespace Duality.Cloning
{
	public interface ICloneTargetSetup
	{
		CloneProviderContext Context { get; }

		void AddTarget<T>(T source, T target) where T : class;
		void HandleObject<T>(T source, T target, CloneBehavior behavior = CloneBehavior.Default, Type behaviorTarget = null) where T : class;
		void HandleValue<T>(ref T source, ref T target, CloneBehavior behavior = CloneBehavior.Default, Type behaviorTarget = null) where T : struct;
	}
}
