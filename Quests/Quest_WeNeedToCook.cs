using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001D2 RID: 466
	public class Quest_WeNeedToCook : Quest
	{
		// Token: 0x0600275C RID: 10076 RVA: 0x000EEF10 File Offset: 0x000ED110
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_WeNeedToCook()
		{
			Il2CppClassPointerStore<Quest_WeNeedToCook>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_WeNeedToCook");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_WeNeedToCook>.NativeClassPtr);
			Quest_WeNeedToCook.NativeFieldInfoPtr_PrerequisiteQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WeNeedToCook>.NativeClassPtr, "PrerequisiteQuests");
			Quest_WeNeedToCook.NativeFieldInfoPtr_MethSupplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WeNeedToCook>.NativeClassPtr, "MethSupplier");
			Quest_WeNeedToCook.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WeNeedToCook>.NativeClassPtr, 100667738);
			Quest_WeNeedToCook.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WeNeedToCook>.NativeClassPtr, 100667739);
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x000EEF90 File Offset: 0x000ED190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120967, XrefRangeEnd = 120970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_WeNeedToCook.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x000EEFCC File Offset: 0x000ED1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120970, XrefRangeEnd = 120974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_WeNeedToCook() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_WeNeedToCook>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WeNeedToCook.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x00015B02 File Offset: 0x00013D02
		public Quest_WeNeedToCook(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x06002760 RID: 10080 RVA: 0x000EF008 File Offset: 0x000ED208
		// (set) Token: 0x06002761 RID: 10081 RVA: 0x00015B0B File Offset: 0x00013D0B
		public unsafe Il2CppReferenceArray<Quest> PrerequisiteQuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WeNeedToCook.NativeFieldInfoPtr_PrerequisiteQuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Quest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WeNeedToCook.NativeFieldInfoPtr_PrerequisiteQuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x06002762 RID: 10082 RVA: 0x000EF038 File Offset: 0x000ED238
		// (set) Token: 0x06002763 RID: 10083 RVA: 0x00015B2A File Offset: 0x00013D2A
		public unsafe Supplier MethSupplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WeNeedToCook.NativeFieldInfoPtr_MethSupplier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WeNeedToCook.NativeFieldInfoPtr_MethSupplier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A2C RID: 6700
		private static readonly IntPtr NativeFieldInfoPtr_PrerequisiteQuests;

		// Token: 0x04001A2D RID: 6701
		private static readonly IntPtr NativeFieldInfoPtr_MethSupplier;

		// Token: 0x04001A2E RID: 6702
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x04001A2F RID: 6703
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
