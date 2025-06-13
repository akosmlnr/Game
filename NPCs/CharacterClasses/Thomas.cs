using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.NPCs.Schedules;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.UI.Handover;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000356 RID: 854
	public class Thomas : NPC
	{
		// Token: 0x06003E09 RID: 15881 RVA: 0x0013DBE4 File Offset: 0x0013BDE4
		// Note: this type is marked as 'beforefieldinit'.
		static Thomas()
		{
			Il2CppClassPointerStore<Thomas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "Thomas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Thomas>.NativeClassPtr);
			Thomas.NativeFieldInfoPtr_CARTEL_CONTRACT_QUANTITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "CARTEL_CONTRACT_QUANTITY");
			Thomas.NativeFieldInfoPtr_CARTEL_CONTRACT_PAYMENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "CARTEL_CONTRACT_PAYMENT");
			Thomas.NativeFieldInfoPtr_FirstMeetingEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "FirstMeetingEvent");
			Thomas.NativeFieldInfoPtr_HandoverEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "HandoverEvent");
			Thomas.NativeFieldInfoPtr_onCartelContractReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "onCartelContractReceived");
			Thomas.NativeFieldInfoPtr__MeetingReminderSent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "<MeetingReminderSent>k__BackingField");
			Thomas.NativeFieldInfoPtr__HandoverReminderSent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "<HandoverReminderSent>k__BackingField");
			Thomas.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.ThomasAssembly-CSharp.dll_Excuted");
			Thomas.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.ThomasAssembly-CSharp.dll_Excuted");
			Thomas.NativeMethodInfoPtr_get_MeetingReminderSent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670617);
			Thomas.NativeMethodInfoPtr_set_MeetingReminderSent_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670618);
			Thomas.NativeMethodInfoPtr_get_HandoverReminderSent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670619);
			Thomas.NativeMethodInfoPtr_set_HandoverReminderSent_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670620);
			Thomas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670621);
			Thomas.NativeMethodInfoPtr_SetFirstMeetingEventActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670622);
			Thomas.NativeMethodInfoPtr_SetHandoverEventActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670623);
			Thomas.NativeMethodInfoPtr_SendMeetingReminder_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670624);
			Thomas.NativeMethodInfoPtr_SendHandoverReminder_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670625);
			Thomas.NativeMethodInfoPtr_InitialMeetingComplete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670626);
			Thomas.NativeMethodInfoPtr_DialogueChoiceCallback_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670627);
			Thomas.NativeMethodInfoPtr_ProcessItemHandover_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670628);
			Thomas.NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670629);
			Thomas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670630);
			Thomas.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670631);
			Thomas.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670632);
			Thomas.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670633);
			Thomas.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670634);
		}

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x06003E0A RID: 15882 RVA: 0x0013DE30 File Offset: 0x0013C030
		// (set) Token: 0x06003E0B RID: 15883 RVA: 0x0013DE6C File Offset: 0x0013C06C
		public unsafe bool MeetingReminderSent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_get_MeetingReminderSent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_set_MeetingReminderSent_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x06003E0C RID: 15884 RVA: 0x0013DEAC File Offset: 0x0013C0AC
		// (set) Token: 0x06003E0D RID: 15885 RVA: 0x0013DEE8 File Offset: 0x0013C0E8
		public unsafe bool HandoverReminderSent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_get_HandoverReminderSent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_set_HandoverReminderSent_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06003E0E RID: 15886 RVA: 0x0013DF28 File Offset: 0x0013C128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148479, XrefRangeEnd = 148490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003E0F RID: 15887 RVA: 0x0013DF64 File Offset: 0x0013C164
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 148493, RefRangeEnd = 148494, XrefRangeStart = 148490, XrefRangeEnd = 148493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFirstMeetingEventActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_SetFirstMeetingEventActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003E10 RID: 15888 RVA: 0x0013DFA4 File Offset: 0x0013C1A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 148497, RefRangeEnd = 148499, XrefRangeStart = 148494, XrefRangeEnd = 148497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHandoverEventActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_SetHandoverEventActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003E11 RID: 15889 RVA: 0x0013DFE4 File Offset: 0x0013C1E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 148511, RefRangeEnd = 148512, XrefRangeStart = 148499, XrefRangeEnd = 148511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMeetingReminder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_SendMeetingReminder_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003E12 RID: 15890 RVA: 0x0013E018 File Offset: 0x0013C218
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 148529, RefRangeEnd = 148530, XrefRangeStart = 148512, XrefRangeEnd = 148529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendHandoverReminder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_SendHandoverReminder_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003E13 RID: 15891 RVA: 0x0013E04C File Offset: 0x0013C24C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 148534, RefRangeEnd = 148535, XrefRangeStart = 148530, XrefRangeEnd = 148534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitialMeetingComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_InitialMeetingComplete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003E14 RID: 15892 RVA: 0x0013E080 File Offset: 0x0013C280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148535, XrefRangeEnd = 148598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DialogueChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_DialogueChoiceCallback_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003E15 RID: 15893 RVA: 0x0013E0C4 File Offset: 0x0013C2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148598, XrefRangeEnd = 148611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessItemHandover(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_ProcessItemHandover_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003E16 RID: 15894 RVA: 0x0013E124 File Offset: 0x0013C324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148611, XrefRangeEnd = 148620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(NPCData data, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003E17 RID: 15895 RVA: 0x0013E184 File Offset: 0x0013C384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Thomas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Thomas>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003E18 RID: 15896 RVA: 0x0013E1C0 File Offset: 0x0013C3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148620, XrefRangeEnd = 148621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003E19 RID: 15897 RVA: 0x0013E1FC File Offset: 0x0013C3FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148621, XrefRangeEnd = 148622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003E1A RID: 15898 RVA: 0x0013E238 File Offset: 0x0013C438
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003E1B RID: 15899 RVA: 0x0013E274 File Offset: 0x0013C474
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 147536, RefRangeEnd = 147540, XrefRangeStart = 147536, XrefRangeEnd = 147540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003E1C RID: 15900 RVA: 0x0001F3BB File Offset: 0x0001D5BB
		public Thomas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x06003E1D RID: 15901 RVA: 0x0013E2B0 File Offset: 0x0013C4B0
		// (set) Token: 0x06003E1E RID: 15902 RVA: 0x0001F3C4 File Offset: 0x0001D5C4
		public unsafe static int CARTEL_CONTRACT_QUANTITY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Thomas.NativeFieldInfoPtr_CARTEL_CONTRACT_QUANTITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thomas.NativeFieldInfoPtr_CARTEL_CONTRACT_QUANTITY, (void*)(&value));
			}
		}

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x06003E1F RID: 15903 RVA: 0x0013E2CC File Offset: 0x0013C4CC
		// (set) Token: 0x06003E20 RID: 15904 RVA: 0x0001F3D2 File Offset: 0x0001D5D2
		public unsafe static float CARTEL_CONTRACT_PAYMENT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Thomas.NativeFieldInfoPtr_CARTEL_CONTRACT_PAYMENT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thomas.NativeFieldInfoPtr_CARTEL_CONTRACT_PAYMENT, (void*)(&value));
			}
		}

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x06003E21 RID: 15905 RVA: 0x0013E2E8 File Offset: 0x0013C4E8
		// (set) Token: 0x06003E22 RID: 15906 RVA: 0x0001F3E0 File Offset: 0x0001D5E0
		public unsafe NPCEvent_LocationDialogue FirstMeetingEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_FirstMeetingEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEvent_LocationDialogue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_FirstMeetingEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x06003E23 RID: 15907 RVA: 0x0013E318 File Offset: 0x0013C518
		// (set) Token: 0x06003E24 RID: 15908 RVA: 0x0001F3FF File Offset: 0x0001D5FF
		public unsafe NPCEvent_LocationDialogue HandoverEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_HandoverEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEvent_LocationDialogue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_HandoverEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x06003E25 RID: 15909 RVA: 0x0013E348 File Offset: 0x0013C548
		// (set) Token: 0x06003E26 RID: 15910 RVA: 0x0001F41E File Offset: 0x0001D61E
		public unsafe UnityEvent onCartelContractReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_onCartelContractReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_onCartelContractReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x06003E27 RID: 15911 RVA: 0x0013E378 File Offset: 0x0013C578
		// (set) Token: 0x06003E28 RID: 15912 RVA: 0x0001F43D File Offset: 0x0001D63D
		public unsafe bool _MeetingReminderSent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr__MeetingReminderSent_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr__MeetingReminderSent_k__BackingField)) = value;
			}
		}

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x06003E29 RID: 15913 RVA: 0x0013E3A0 File Offset: 0x0013C5A0
		// (set) Token: 0x06003E2A RID: 15914 RVA: 0x0001F458 File Offset: 0x0001D658
		public unsafe bool _HandoverReminderSent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr__HandoverReminderSent_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr__HandoverReminderSent_k__BackingField)) = value;
			}
		}

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x06003E2B RID: 15915 RVA: 0x0013E3C8 File Offset: 0x0013C5C8
		// (set) Token: 0x06003E2C RID: 15916 RVA: 0x0001F473 File Offset: 0x0001D673
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x06003E2D RID: 15917 RVA: 0x0013E3F0 File Offset: 0x0013C5F0
		// (set) Token: 0x06003E2E RID: 15918 RVA: 0x0001F48E File Offset: 0x0001D68E
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040028E8 RID: 10472
		private static readonly IntPtr NativeFieldInfoPtr_CARTEL_CONTRACT_QUANTITY;

		// Token: 0x040028E9 RID: 10473
		private static readonly IntPtr NativeFieldInfoPtr_CARTEL_CONTRACT_PAYMENT;

		// Token: 0x040028EA RID: 10474
		private static readonly IntPtr NativeFieldInfoPtr_FirstMeetingEvent;

		// Token: 0x040028EB RID: 10475
		private static readonly IntPtr NativeFieldInfoPtr_HandoverEvent;

		// Token: 0x040028EC RID: 10476
		private static readonly IntPtr NativeFieldInfoPtr_onCartelContractReceived;

		// Token: 0x040028ED RID: 10477
		private static readonly IntPtr NativeFieldInfoPtr__MeetingReminderSent_k__BackingField;

		// Token: 0x040028EE RID: 10478
		private static readonly IntPtr NativeFieldInfoPtr__HandoverReminderSent_k__BackingField;

		// Token: 0x040028EF RID: 10479
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040028F0 RID: 10480
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040028F1 RID: 10481
		private static readonly IntPtr NativeMethodInfoPtr_get_MeetingReminderSent_Public_get_Boolean_0;

		// Token: 0x040028F2 RID: 10482
		private static readonly IntPtr NativeMethodInfoPtr_set_MeetingReminderSent_Protected_set_Void_Boolean_0;

		// Token: 0x040028F3 RID: 10483
		private static readonly IntPtr NativeMethodInfoPtr_get_HandoverReminderSent_Public_get_Boolean_0;

		// Token: 0x040028F4 RID: 10484
		private static readonly IntPtr NativeMethodInfoPtr_set_HandoverReminderSent_Protected_set_Void_Boolean_0;

		// Token: 0x040028F5 RID: 10485
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040028F6 RID: 10486
		private static readonly IntPtr NativeMethodInfoPtr_SetFirstMeetingEventActive_Public_Void_Boolean_0;

		// Token: 0x040028F7 RID: 10487
		private static readonly IntPtr NativeMethodInfoPtr_SetHandoverEventActive_Public_Void_Boolean_0;

		// Token: 0x040028F8 RID: 10488
		private static readonly IntPtr NativeMethodInfoPtr_SendMeetingReminder_Public_Void_0;

		// Token: 0x040028F9 RID: 10489
		private static readonly IntPtr NativeMethodInfoPtr_SendHandoverReminder_Public_Void_0;

		// Token: 0x040028FA RID: 10490
		private static readonly IntPtr NativeMethodInfoPtr_InitialMeetingComplete_Public_Void_0;

		// Token: 0x040028FB RID: 10491
		private static readonly IntPtr NativeMethodInfoPtr_DialogueChoiceCallback_Private_Void_String_0;

		// Token: 0x040028FC RID: 10492
		private static readonly IntPtr NativeMethodInfoPtr_ProcessItemHandover_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0;

		// Token: 0x040028FD RID: 10493
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0;

		// Token: 0x040028FE RID: 10494
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040028FF RID: 10495
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002900 RID: 10496
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002901 RID: 10497
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002902 RID: 10498
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
