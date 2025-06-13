using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.Product;
using Il2CppSystem;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001B7 RID: 439
	[System.Serializable]
	public class ContractInfo : Il2CppSystem.Object
	{
		// Token: 0x060024F6 RID: 9462 RVA: 0x000E6480 File Offset: 0x000E4680
		// Note: this type is marked as 'beforefieldinit'.
		static ContractInfo()
		{
			Il2CppClassPointerStore<ContractInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "ContractInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr);
			ContractInfo.NativeFieldInfoPtr_Payment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "Payment");
			ContractInfo.NativeFieldInfoPtr_Products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "Products");
			ContractInfo.NativeFieldInfoPtr_DeliveryLocationGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "DeliveryLocationGUID");
			ContractInfo.NativeFieldInfoPtr_DeliveryWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "DeliveryWindow");
			ContractInfo.NativeFieldInfoPtr_Expires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "Expires");
			ContractInfo.NativeFieldInfoPtr_ExpiresAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "ExpiresAfter");
			ContractInfo.NativeFieldInfoPtr_PickupScheduleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "PickupScheduleIndex");
			ContractInfo.NativeFieldInfoPtr_IsCounterOffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "IsCounterOffer");
			ContractInfo.NativeFieldInfoPtr__DeliveryLocation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "<DeliveryLocation>k__BackingField");
			ContractInfo.NativeMethodInfoPtr_get_DeliveryLocation_Public_get_DeliveryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, 100667432);
			ContractInfo.NativeMethodInfoPtr_set_DeliveryLocation_Private_set_Void_DeliveryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, 100667433);
			ContractInfo.NativeMethodInfoPtr__ctor_Public_Void_Single_ProductList_String_QuestWindowConfig_Boolean_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, 100667434);
			ContractInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, 100667435);
			ContractInfo.NativeMethodInfoPtr_ProcessMessage_Public_DialogueChain_DialogueChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, 100667436);
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x060024F7 RID: 9463 RVA: 0x000E65C8 File Offset: 0x000E47C8
		// (set) Token: 0x060024F8 RID: 9464 RVA: 0x000E6608 File Offset: 0x000E4808
		public unsafe DeliveryLocation DeliveryLocation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37506, RefRangeEnd = 37507, XrefRangeStart = 37506, XrefRangeEnd = 37507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractInfo.NativeMethodInfoPtr_get_DeliveryLocation_Public_get_DeliveryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryLocation>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractInfo.NativeMethodInfoPtr_set_DeliveryLocation_Private_set_Void_DeliveryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x000E664C File Offset: 0x000E484C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117046, RefRangeEnd = 117048, XrefRangeStart = 117031, XrefRangeEnd = 117046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContractInfo(float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, bool expires, int expiresAfter, int pickupScheduleIndex, bool isCounterOffer) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)8) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref payment;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(products);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deliveryLocationGUID);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deliveryWindow);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref expires;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref expiresAfter;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref pickupScheduleIndex;
			ptr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref isCounterOffer;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractInfo.NativeMethodInfoPtr__ctor_Public_Void_Single_ProductList_String_QuestWindowConfig_Boolean_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x000E6704 File Offset: 0x000E4904
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContractInfo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x000E6740 File Offset: 0x000E4940
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 117116, RefRangeEnd = 117119, XrefRangeStart = 117048, XrefRangeEnd = 117116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChain ProcessMessage(DialogueChain messageChain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(messageChain);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractInfo.NativeMethodInfoPtr_ProcessMessage_Public_DialogueChain_DialogueChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueChain>(intPtr2) : null;
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x000149D3 File Offset: 0x00012BD3
		public ContractInfo(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x060024FD RID: 9469 RVA: 0x000E6790 File Offset: 0x000E4990
		// (set) Token: 0x060024FE RID: 9470 RVA: 0x000149DC File Offset: 0x00012BDC
		public unsafe float Payment
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_Payment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_Payment)) = value;
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x060024FF RID: 9471 RVA: 0x000E67B8 File Offset: 0x000E49B8
		// (set) Token: 0x06002500 RID: 9472 RVA: 0x000149F7 File Offset: 0x00012BF7
		public unsafe ProductList Products
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_Products);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductList>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_Products), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x06002501 RID: 9473 RVA: 0x000E67E8 File Offset: 0x000E49E8
		// (set) Token: 0x06002502 RID: 9474 RVA: 0x00014A16 File Offset: 0x00012C16
		public unsafe string DeliveryLocationGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_DeliveryLocationGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_DeliveryLocationGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x06002503 RID: 9475 RVA: 0x000E6810 File Offset: 0x000E4A10
		// (set) Token: 0x06002504 RID: 9476 RVA: 0x00014A35 File Offset: 0x00012C35
		public unsafe QuestWindowConfig DeliveryWindow
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_DeliveryWindow);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestWindowConfig>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_DeliveryWindow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x06002505 RID: 9477 RVA: 0x000E6840 File Offset: 0x000E4A40
		// (set) Token: 0x06002506 RID: 9478 RVA: 0x00014A54 File Offset: 0x00012C54
		public unsafe bool Expires
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_Expires);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_Expires)) = value;
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x06002507 RID: 9479 RVA: 0x000E6868 File Offset: 0x000E4A68
		// (set) Token: 0x06002508 RID: 9480 RVA: 0x00014A6F File Offset: 0x00012C6F
		public unsafe int ExpiresAfter
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_ExpiresAfter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_ExpiresAfter)) = value;
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x06002509 RID: 9481 RVA: 0x000E6890 File Offset: 0x000E4A90
		// (set) Token: 0x0600250A RID: 9482 RVA: 0x00014A8A File Offset: 0x00012C8A
		public unsafe int PickupScheduleIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_PickupScheduleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_PickupScheduleIndex)) = value;
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x0600250B RID: 9483 RVA: 0x000E68B8 File Offset: 0x000E4AB8
		// (set) Token: 0x0600250C RID: 9484 RVA: 0x00014AA5 File Offset: 0x00012CA5
		public unsafe bool IsCounterOffer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_IsCounterOffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_IsCounterOffer)) = value;
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x0600250D RID: 9485 RVA: 0x000E68E0 File Offset: 0x000E4AE0
		// (set) Token: 0x0600250E RID: 9486 RVA: 0x00014AC0 File Offset: 0x00012CC0
		public unsafe DeliveryLocation _DeliveryLocation_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr__DeliveryLocation_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryLocation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr__DeliveryLocation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400187F RID: 6271
		private static readonly System.IntPtr NativeFieldInfoPtr_Payment;

		// Token: 0x04001880 RID: 6272
		private static readonly System.IntPtr NativeFieldInfoPtr_Products;

		// Token: 0x04001881 RID: 6273
		private static readonly System.IntPtr NativeFieldInfoPtr_DeliveryLocationGUID;

		// Token: 0x04001882 RID: 6274
		private static readonly System.IntPtr NativeFieldInfoPtr_DeliveryWindow;

		// Token: 0x04001883 RID: 6275
		private static readonly System.IntPtr NativeFieldInfoPtr_Expires;

		// Token: 0x04001884 RID: 6276
		private static readonly System.IntPtr NativeFieldInfoPtr_ExpiresAfter;

		// Token: 0x04001885 RID: 6277
		private static readonly System.IntPtr NativeFieldInfoPtr_PickupScheduleIndex;

		// Token: 0x04001886 RID: 6278
		private static readonly System.IntPtr NativeFieldInfoPtr_IsCounterOffer;

		// Token: 0x04001887 RID: 6279
		private static readonly System.IntPtr NativeFieldInfoPtr__DeliveryLocation_k__BackingField;

		// Token: 0x04001888 RID: 6280
		private static readonly System.IntPtr NativeMethodInfoPtr_get_DeliveryLocation_Public_get_DeliveryLocation_0;

		// Token: 0x04001889 RID: 6281
		private static readonly System.IntPtr NativeMethodInfoPtr_set_DeliveryLocation_Private_set_Void_DeliveryLocation_0;

		// Token: 0x0400188A RID: 6282
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_ProductList_String_QuestWindowConfig_Boolean_Int32_Int32_Boolean_0;

		// Token: 0x0400188B RID: 6283
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400188C RID: 6284
		private static readonly System.IntPtr NativeMethodInfoPtr_ProcessMessage_Public_DialogueChain_DialogueChain_0;
	}
}
