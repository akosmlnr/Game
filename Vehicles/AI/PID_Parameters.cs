using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x02000529 RID: 1321
	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct PID_Parameters
	{
		// Token: 0x06007337 RID: 29495 RVA: 0x001FB758 File Offset: 0x001F9958
		// Note: this type is marked as 'beforefieldinit'.
		static PID_Parameters()
		{
			Il2CppClassPointerStore<PID_Parameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "PID_Parameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PID_Parameters>.NativeClassPtr);
			PID_Parameters.NativeFieldInfoPtr_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID_Parameters>.NativeClassPtr, "P");
			PID_Parameters.NativeFieldInfoPtr_I = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID_Parameters>.NativeClassPtr, "I");
			PID_Parameters.NativeFieldInfoPtr_D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID_Parameters>.NativeClassPtr, "D");
			PID_Parameters.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PID_Parameters>.NativeClassPtr, 100677874);
		}

		// Token: 0x06007338 RID: 29496 RVA: 0x001FB7D8 File Offset: 0x001F99D8
		[CallerCount(0)]
		public unsafe PID_Parameters(float P, float I, float D)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref P;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref I;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref D;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PID_Parameters.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007339 RID: 29497 RVA: 0x000367E3 File Offset: 0x000349E3
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PID_Parameters>.NativeClassPtr, ref this));
		}

		// Token: 0x04004EAD RID: 20141
		private static readonly System.IntPtr NativeFieldInfoPtr_P;

		// Token: 0x04004EAE RID: 20142
		private static readonly System.IntPtr NativeFieldInfoPtr_I;

		// Token: 0x04004EAF RID: 20143
		private static readonly System.IntPtr NativeFieldInfoPtr_D;

		// Token: 0x04004EB0 RID: 20144
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;

		// Token: 0x04004EB1 RID: 20145
		[FieldOffset(0)]
		public float P;

		// Token: 0x04004EB2 RID: 20146
		[FieldOffset(4)]
		public float I;

		// Token: 0x04004EB3 RID: 20147
		[FieldOffset(8)]
		public float D;
	}
}
