using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.NPCs.CharacterClasses;
using Il2CppScheduleOne.Property;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001CF RID: 463
	public class Quest_UnfavourableAgreements : Quest
	{
		// Token: 0x06002723 RID: 10019 RVA: 0x000EE514 File Offset: 0x000EC714
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_UnfavourableAgreements()
		{
			Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_UnfavourableAgreements");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr);
			Quest_UnfavourableAgreements.NativeFieldInfoPtr_WEEKLY_DELIVERY_HOURS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, "WEEKLY_DELIVERY_HOURS");
			Quest_UnfavourableAgreements.NativeFieldInfoPtr_REMINDER_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, "REMINDER_THRESHOLD");
			Quest_UnfavourableAgreements.NativeFieldInfoPtr_Thomas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, "Thomas");
			Quest_UnfavourableAgreements.NativeFieldInfoPtr_Gate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, "Gate");
			Quest_UnfavourableAgreements.NativeFieldInfoPtr_Switch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, "Switch");
			Quest_UnfavourableAgreements.NativeFieldInfoPtr_RV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, "RV");
			Quest_UnfavourableAgreements.NativeFieldInfoPtr_QuestEntryTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, "QuestEntryTitle");
			Quest_UnfavourableAgreements.NativeFieldInfoPtr_handoverSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, "handoverSetup");
			Quest_UnfavourableAgreements.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667715);
			Quest_UnfavourableAgreements.NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667716);
			Quest_UnfavourableAgreements.NativeMethodInfoPtr_HourPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667717);
			Quest_UnfavourableAgreements.NativeMethodInfoPtr_SetupHandover_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667718);
			Quest_UnfavourableAgreements.NativeMethodInfoPtr_CheckHandoverExpiry_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667719);
			Quest_UnfavourableAgreements.NativeMethodInfoPtr_UpdateName_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667720);
			Quest_UnfavourableAgreements.NativeMethodInfoPtr_HandoverCompleted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667721);
			Quest_UnfavourableAgreements.NativeMethodInfoPtr_ResetTimer_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667722);
			Quest_UnfavourableAgreements.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667723);
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x000EE698 File Offset: 0x000EC898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120710, XrefRangeEnd = 120747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_UnfavourableAgreements.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x000EE6D4 File Offset: 0x000EC8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120747, XrefRangeEnd = 120749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_UnfavourableAgreements.NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x000EE720 File Offset: 0x000EC920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120749, XrefRangeEnd = 120791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HourPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_UnfavourableAgreements.NativeMethodInfoPtr_HourPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x000EE754 File Offset: 0x000EC954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120791, XrefRangeEnd = 120801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupHandover()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_UnfavourableAgreements.NativeMethodInfoPtr_SetupHandover_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x000EE788 File Offset: 0x000EC988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120801, XrefRangeEnd = 120824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckHandoverExpiry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_UnfavourableAgreements.NativeMethodInfoPtr_CheckHandoverExpiry_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x000EE7BC File Offset: 0x000EC9BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 120860, RefRangeEnd = 120863, XrefRangeStart = 120824, XrefRangeEnd = 120860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_UnfavourableAgreements.NativeMethodInfoPtr_UpdateName_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x000EE7F0 File Offset: 0x000EC9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120863, XrefRangeEnd = 120864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandoverCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_UnfavourableAgreements.NativeMethodInfoPtr_HandoverCompleted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x000EE824 File Offset: 0x000ECA24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 120893, RefRangeEnd = 120896, XrefRangeStart = 120864, XrefRangeEnd = 120893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetTimer(bool allowBuildup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref allowBuildup;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_UnfavourableAgreements.NativeMethodInfoPtr_ResetTimer_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x000EE864 File Offset: 0x000ECA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120896, XrefRangeEnd = 120900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_UnfavourableAgreements() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_UnfavourableAgreements.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x0001590E File Offset: 0x00013B0E
		public Quest_UnfavourableAgreements(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x0600272E RID: 10030 RVA: 0x000EE8A0 File Offset: 0x000ECAA0
		// (set) Token: 0x0600272F RID: 10031 RVA: 0x00015917 File Offset: 0x00013B17
		public unsafe static float WEEKLY_DELIVERY_HOURS
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Quest_UnfavourableAgreements.NativeFieldInfoPtr_WEEKLY_DELIVERY_HOURS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest_UnfavourableAgreements.NativeFieldInfoPtr_WEEKLY_DELIVERY_HOURS, (void*)(&value));
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x06002730 RID: 10032 RVA: 0x000EE8BC File Offset: 0x000ECABC
		// (set) Token: 0x06002731 RID: 10033 RVA: 0x00015925 File Offset: 0x00013B25
		public unsafe static float REMINDER_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Quest_UnfavourableAgreements.NativeFieldInfoPtr_REMINDER_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest_UnfavourableAgreements.NativeFieldInfoPtr_REMINDER_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x06002732 RID: 10034 RVA: 0x000EE8D8 File Offset: 0x000ECAD8
		// (set) Token: 0x06002733 RID: 10035 RVA: 0x00015933 File Offset: 0x00013B33
		public unsafe Thomas Thomas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_Thomas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Thomas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_Thomas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x06002734 RID: 10036 RVA: 0x000EE908 File Offset: 0x000ECB08
		// (set) Token: 0x06002735 RID: 10037 RVA: 0x00015952 File Offset: 0x00013B52
		public unsafe ManorGate Gate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_Gate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManorGate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_Gate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x06002736 RID: 10038 RVA: 0x000EE938 File Offset: 0x000ECB38
		// (set) Token: 0x06002737 RID: 10039 RVA: 0x00015971 File Offset: 0x00013B71
		public unsafe ModularSwitch Switch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_Switch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModularSwitch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_Switch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x06002738 RID: 10040 RVA: 0x000EE968 File Offset: 0x000ECB68
		// (set) Token: 0x06002739 RID: 10041 RVA: 0x00015990 File Offset: 0x00013B90
		public unsafe RV RV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_RV);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RV>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_RV), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x0600273A RID: 10042 RVA: 0x000EE998 File Offset: 0x000ECB98
		// (set) Token: 0x0600273B RID: 10043 RVA: 0x000159AF File Offset: 0x00013BAF
		public unsafe string QuestEntryTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_QuestEntryTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_QuestEntryTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x0600273C RID: 10044 RVA: 0x000EE9C0 File Offset: 0x000ECBC0
		// (set) Token: 0x0600273D RID: 10045 RVA: 0x000159CE File Offset: 0x00013BCE
		public unsafe bool handoverSetup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_handoverSetup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_handoverSetup)) = value;
			}
		}

		// Token: 0x04001A0A RID: 6666
		private static readonly IntPtr NativeFieldInfoPtr_WEEKLY_DELIVERY_HOURS;

		// Token: 0x04001A0B RID: 6667
		private static readonly IntPtr NativeFieldInfoPtr_REMINDER_THRESHOLD;

		// Token: 0x04001A0C RID: 6668
		private static readonly IntPtr NativeFieldInfoPtr_Thomas;

		// Token: 0x04001A0D RID: 6669
		private static readonly IntPtr NativeFieldInfoPtr_Gate;

		// Token: 0x04001A0E RID: 6670
		private static readonly IntPtr NativeFieldInfoPtr_Switch;

		// Token: 0x04001A0F RID: 6671
		private static readonly IntPtr NativeFieldInfoPtr_RV;

		// Token: 0x04001A10 RID: 6672
		private static readonly IntPtr NativeFieldInfoPtr_QuestEntryTitle;

		// Token: 0x04001A11 RID: 6673
		private static readonly IntPtr NativeFieldInfoPtr_handoverSetup;

		// Token: 0x04001A12 RID: 6674
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001A13 RID: 6675
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0;

		// Token: 0x04001A14 RID: 6676
		private static readonly IntPtr NativeMethodInfoPtr_HourPass_Private_Void_0;

		// Token: 0x04001A15 RID: 6677
		private static readonly IntPtr NativeMethodInfoPtr_SetupHandover_Private_Void_0;

		// Token: 0x04001A16 RID: 6678
		private static readonly IntPtr NativeMethodInfoPtr_CheckHandoverExpiry_Private_Void_0;

		// Token: 0x04001A17 RID: 6679
		private static readonly IntPtr NativeMethodInfoPtr_UpdateName_Private_Void_0;

		// Token: 0x04001A18 RID: 6680
		private static readonly IntPtr NativeMethodInfoPtr_HandoverCompleted_Private_Void_0;

		// Token: 0x04001A19 RID: 6681
		private static readonly IntPtr NativeMethodInfoPtr_ResetTimer_Public_Void_Boolean_0;

		// Token: 0x04001A1A RID: 6682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
