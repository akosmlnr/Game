using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x020004B5 RID: 1205
	public class IDamageable : Il2CppObjectBase
	{
		// Token: 0x06006735 RID: 26421 RVA: 0x001D3AF4 File Offset: 0x001D1CF4
		// Note: this type is marked as 'beforefieldinit'.
		static IDamageable()
		{
			Il2CppClassPointerStore<IDamageable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "IDamageable");
			IDamageable.NativeMethodInfoPtr_SendImpact_Public_Abstract_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamageable>.NativeClassPtr, 100676453);
			IDamageable.NativeMethodInfoPtr_ReceiveImpact_Public_Abstract_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamageable>.NativeClassPtr, 100676454);
		}

		// Token: 0x06006736 RID: 26422 RVA: 0x001D3B44 File Offset: 0x001D1D44
		[CallerCount(0)]
		public unsafe virtual void SendImpact(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDamageable.NativeMethodInfoPtr_SendImpact_Public_Abstract_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006737 RID: 26423 RVA: 0x001D3B94 File Offset: 0x001D1D94
		[CallerCount(0)]
		public unsafe virtual void ReceiveImpact(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDamageable.NativeMethodInfoPtr_ReceiveImpact_Public_Abstract_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006738 RID: 26424 RVA: 0x00030929 File Offset: 0x0002EB29
		public IDamageable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004670 RID: 18032
		private static readonly IntPtr NativeMethodInfoPtr_SendImpact_Public_Abstract_Virtual_New_Void_Impact_0;

		// Token: 0x04004671 RID: 18033
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveImpact_Public_Abstract_Virtual_New_Void_Impact_0;
	}
}
