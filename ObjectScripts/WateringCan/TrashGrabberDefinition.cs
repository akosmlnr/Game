using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x02000785 RID: 1925
	[Serializable]
	public class TrashGrabberDefinition : StorableItemDefinition
	{
		// Token: 0x0600B728 RID: 46888 RVA: 0x002DD7F0 File Offset: 0x002DB9F0
		// Note: this type is marked as 'beforefieldinit'.
		static TrashGrabberDefinition()
		{
			Il2CppClassPointerStore<TrashGrabberDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.WateringCan", "TrashGrabberDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashGrabberDefinition>.NativeClassPtr);
			TrashGrabberDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberDefinition>.NativeClassPtr, 100686037);
			TrashGrabberDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberDefinition>.NativeClassPtr, 100686038);
		}

		// Token: 0x0600B729 RID: 46889 RVA: 0x002DD848 File Offset: 0x002DBA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314666, XrefRangeEnd = 314670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashGrabberDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x0600B72A RID: 46890 RVA: 0x002DD8A0 File Offset: 0x002DBAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashGrabberDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGrabberDefinition>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B72B RID: 46891 RVA: 0x00059671 File Offset: 0x00057871
		public TrashGrabberDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04007BB5 RID: 31669
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04007BB6 RID: 31670
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
