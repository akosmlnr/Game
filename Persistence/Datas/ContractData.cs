using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Quests;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002CB RID: 715
	[Serializable]
	public class ContractData : QuestData
	{
		// Token: 0x060032C1 RID: 12993 RVA: 0x00115250 File Offset: 0x00113450
		// Note: this type is marked as 'beforefieldinit'.
		static ContractData()
		{
			Il2CppClassPointerStore<ContractData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ContractData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContractData>.NativeClassPtr);
			ContractData.NativeFieldInfoPtr_CustomerGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "CustomerGUID");
			ContractData.NativeFieldInfoPtr_Payment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "Payment");
			ContractData.NativeFieldInfoPtr_ProductList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "ProductList");
			ContractData.NativeFieldInfoPtr_DeliveryLocationGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "DeliveryLocationGUID");
			ContractData.NativeFieldInfoPtr_DeliveryWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "DeliveryWindow");
			ContractData.NativeFieldInfoPtr_PickupScheduleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "PickupScheduleIndex");
			ContractData.NativeFieldInfoPtr_AcceptTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "AcceptTime");
			ContractData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_String_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractData>.NativeClassPtr, 100669082);
		}

		// Token: 0x060032C2 RID: 12994 RVA: 0x00115320 File Offset: 0x00113520
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137066, RefRangeEnd = 137067, XrefRangeStart = 137060, XrefRangeEnd = 137066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContractData(string guid, EQuestState state, bool isTracked, string title, string desc, bool isTimed, GameDateTimeData expiry, Il2CppReferenceArray<QuestEntryData> entries, string customerGUID, float payment, ProductList productList, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, int pickupScheduleIndex, GameDateTimeData acceptTime) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContractData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTracked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(desc);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTimed;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expiry);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entries);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(customerGUID);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref payment;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productList);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deliveryLocationGUID);
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deliveryWindow);
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pickupScheduleIndex;
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(acceptTime);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_String_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060032C3 RID: 12995 RVA: 0x0001AE2B File Offset: 0x0001902B
		public ContractData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x060032C4 RID: 12996 RVA: 0x00115464 File Offset: 0x00113664
		// (set) Token: 0x060032C5 RID: 12997 RVA: 0x0001AE34 File Offset: 0x00019034
		public unsafe string CustomerGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_CustomerGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_CustomerGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x060032C6 RID: 12998 RVA: 0x0011548C File Offset: 0x0011368C
		// (set) Token: 0x060032C7 RID: 12999 RVA: 0x0001AE53 File Offset: 0x00019053
		public unsafe float Payment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_Payment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_Payment)) = value;
			}
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x060032C8 RID: 13000 RVA: 0x001154B4 File Offset: 0x001136B4
		// (set) Token: 0x060032C9 RID: 13001 RVA: 0x0001AE6E File Offset: 0x0001906E
		public unsafe ProductList ProductList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_ProductList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_ProductList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x060032CA RID: 13002 RVA: 0x001154E4 File Offset: 0x001136E4
		// (set) Token: 0x060032CB RID: 13003 RVA: 0x0001AE8D File Offset: 0x0001908D
		public unsafe string DeliveryLocationGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_DeliveryLocationGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_DeliveryLocationGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x060032CC RID: 13004 RVA: 0x0011550C File Offset: 0x0011370C
		// (set) Token: 0x060032CD RID: 13005 RVA: 0x0001AEAC File Offset: 0x000190AC
		public unsafe QuestWindowConfig DeliveryWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_DeliveryWindow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestWindowConfig>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_DeliveryWindow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x060032CE RID: 13006 RVA: 0x0011553C File Offset: 0x0011373C
		// (set) Token: 0x060032CF RID: 13007 RVA: 0x0001AECB File Offset: 0x000190CB
		public unsafe int PickupScheduleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_PickupScheduleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_PickupScheduleIndex)) = value;
			}
		}

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x060032D0 RID: 13008 RVA: 0x00115564 File Offset: 0x00113764
		// (set) Token: 0x060032D1 RID: 13009 RVA: 0x0001AEE6 File Offset: 0x000190E6
		public unsafe GameDateTimeData AcceptTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_AcceptTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameDateTimeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_AcceptTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002105 RID: 8453
		private static readonly IntPtr NativeFieldInfoPtr_CustomerGUID;

		// Token: 0x04002106 RID: 8454
		private static readonly IntPtr NativeFieldInfoPtr_Payment;

		// Token: 0x04002107 RID: 8455
		private static readonly IntPtr NativeFieldInfoPtr_ProductList;

		// Token: 0x04002108 RID: 8456
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryLocationGUID;

		// Token: 0x04002109 RID: 8457
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryWindow;

		// Token: 0x0400210A RID: 8458
		private static readonly IntPtr NativeFieldInfoPtr_PickupScheduleIndex;

		// Token: 0x0400210B RID: 8459
		private static readonly IntPtr NativeFieldInfoPtr_AcceptTime;

		// Token: 0x0400210C RID: 8460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_String_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTimeData_0;
	}
}
