using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001D0 RID: 464
	public class Quest_Warehouse : Quest
	{
		// Token: 0x0600273E RID: 10046 RVA: 0x000EE9E8 File Offset: 0x000ECBE8
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_Warehouse()
		{
			Il2CppClassPointerStore<Quest_Warehouse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_Warehouse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_Warehouse>.NativeClassPtr);
			Quest_Warehouse.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Warehouse>.NativeClassPtr, 100667724);
			Quest_Warehouse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Warehouse>.NativeClassPtr, 100667725);
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x000EEA40 File Offset: 0x000ECC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_Warehouse.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x000EEA7C File Offset: 0x000ECC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120900, XrefRangeEnd = 120904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_Warehouse() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_Warehouse>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_Warehouse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x000159E9 File Offset: 0x00013BE9
		public Quest_Warehouse(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001A1B RID: 6683
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x04001A1C RID: 6684
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
