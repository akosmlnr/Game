using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppScheduleOne
{
	// Token: 0x02000173 RID: 371
	public class IGUIDRegisterable : Il2CppObjectBase
	{
		// Token: 0x06001D90 RID: 7568 RVA: 0x000CF494 File Offset: 0x000CD694
		// Note: this type is marked as 'beforefieldinit'.
		static IGUIDRegisterable()
		{
			Il2CppClassPointerStore<IGUIDRegisterable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "IGUIDRegisterable");
			IGUIDRegisterable.NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGUIDRegisterable>.NativeClassPtr, 100666679);
			IGUIDRegisterable.NativeMethodInfoPtr_SetGUID_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGUIDRegisterable>.NativeClassPtr, 100666680);
			IGUIDRegisterable.NativeMethodInfoPtr_SetGUID_Public_Abstract_Virtual_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGUIDRegisterable>.NativeClassPtr, 100666681);
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06001D91 RID: 7569 RVA: 0x000CF4F8 File Offset: 0x000CD6F8
		public unsafe virtual Il2CppSystem.Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGUIDRegisterable.NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x000CF540 File Offset: 0x000CD740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108241, XrefRangeEnd = 108253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGUIDRegisterable.NativeMethodInfoPtr_SetGUID_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x000CF590 File Offset: 0x000CD790
		[CallerCount(0)]
		public unsafe virtual void SetGUID(Il2CppSystem.Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGUIDRegisterable.NativeMethodInfoPtr_SetGUID_Public_Abstract_Virtual_New_Void_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x00010B1D File Offset: 0x0000ED1D
		public IGUIDRegisterable(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001397 RID: 5015
		private static readonly System.IntPtr NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0;

		// Token: 0x04001398 RID: 5016
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_New_Void_String_0;

		// Token: 0x04001399 RID: 5017
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGUID_Public_Abstract_Virtual_New_Void_Guid_0;
	}
}
