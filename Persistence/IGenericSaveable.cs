using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x02000227 RID: 551
	public class IGenericSaveable : Il2CppObjectBase
	{
		// Token: 0x06002D5A RID: 11610 RVA: 0x001032E8 File Offset: 0x001014E8
		// Note: this type is marked as 'beforefieldinit'.
		static IGenericSaveable()
		{
			Il2CppClassPointerStore<IGenericSaveable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "IGenericSaveable");
			IGenericSaveable.NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericSaveable>.NativeClassPtr, 100668447);
			IGenericSaveable.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericSaveable>.NativeClassPtr, 100668448);
			IGenericSaveable.NativeMethodInfoPtr_Load_Public_Abstract_Virtual_New_Void_GenericSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericSaveable>.NativeClassPtr, 100668449);
			IGenericSaveable.NativeMethodInfoPtr_GetSaveData_Public_Abstract_Virtual_New_GenericSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericSaveable>.NativeClassPtr, 100668450);
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06002D5B RID: 11611 RVA: 0x00103360 File Offset: 0x00101560
		public unsafe virtual Il2CppSystem.Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericSaveable.NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06002D5C RID: 11612 RVA: 0x001033A8 File Offset: 0x001015A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127769, XrefRangeEnd = 127784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericSaveable.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x001033E4 File Offset: 0x001015E4
		[CallerCount(0)]
		public unsafe virtual void Load(GenericSaveData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericSaveable.NativeMethodInfoPtr_Load_Public_Abstract_Virtual_New_Void_GenericSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x00103434 File Offset: 0x00101634
		[CallerCount(0)]
		public unsafe virtual GenericSaveData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericSaveable.NativeMethodInfoPtr_GetSaveData_Public_Abstract_Virtual_New_GenericSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericSaveData>(intPtr2) : null;
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x0001858D File Offset: 0x0001678D
		public IGenericSaveable(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E13 RID: 7699
		private static readonly System.IntPtr NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0;

		// Token: 0x04001E14 RID: 7700
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04001E15 RID: 7701
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Abstract_Virtual_New_Void_GenericSaveData_0;

		// Token: 0x04001E16 RID: 7702
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveData_Public_Abstract_Virtual_New_GenericSaveData_0;
	}
}
