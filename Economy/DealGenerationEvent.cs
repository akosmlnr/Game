using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.UI.Phone.Messages;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000434 RID: 1076
	[System.Serializable]
	public class DealGenerationEvent : Il2CppSystem.Object
	{
		// Token: 0x06005D38 RID: 23864 RVA: 0x001B2770 File Offset: 0x001B0970
		// Note: this type is marked as 'beforefieldinit'.
		static DealGenerationEvent()
		{
			Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "DealGenerationEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr);
			DealGenerationEvent.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "Enabled");
			DealGenerationEvent.NativeFieldInfoPtr_CanBeAccepted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "CanBeAccepted");
			DealGenerationEvent.NativeFieldInfoPtr_CanBeRejected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "CanBeRejected");
			DealGenerationEvent.NativeFieldInfoPtr_ApplicableDays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "ApplicableDays");
			DealGenerationEvent.NativeFieldInfoPtr_GenerationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "GenerationTime");
			DealGenerationEvent.NativeFieldInfoPtr_GenerationWindowDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "GenerationWindowDuration");
			DealGenerationEvent.NativeFieldInfoPtr_ProductList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "ProductList");
			DealGenerationEvent.NativeFieldInfoPtr_Payment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "Payment");
			DealGenerationEvent.NativeFieldInfoPtr_RelationshipRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "RelationshipRequirement");
			DealGenerationEvent.NativeFieldInfoPtr_RequestMessageChains = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "RequestMessageChains");
			DealGenerationEvent.NativeFieldInfoPtr_ContractAcceptedResponses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "ContractAcceptedResponses");
			DealGenerationEvent.NativeFieldInfoPtr_ContractRejectedResponses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "ContractRejectedResponses");
			DealGenerationEvent.NativeFieldInfoPtr_DeliveryLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "DeliveryLocation");
			DealGenerationEvent.NativeFieldInfoPtr_PickupScheduleGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "PickupScheduleGroup");
			DealGenerationEvent.NativeFieldInfoPtr_DeliveryWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "DeliveryWindow");
			DealGenerationEvent.NativeFieldInfoPtr_Expires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "Expires");
			DealGenerationEvent.NativeFieldInfoPtr_ExpiresAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "ExpiresAfter");
			DealGenerationEvent.NativeMethodInfoPtr_GenerateContractInfo_Public_ContractInfo_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100675284);
			DealGenerationEvent.NativeMethodInfoPtr_ShouldGenerate_Public_Boolean_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100675285);
			DealGenerationEvent.NativeMethodInfoPtr_GetRandomRequestMessage_Public_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100675286);
			DealGenerationEvent.NativeMethodInfoPtr_ProcessMessage_Public_MessageChain_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100675287);
			DealGenerationEvent.NativeMethodInfoPtr_GetRejectionMessage_Public_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100675288);
			DealGenerationEvent.NativeMethodInfoPtr_GetAcceptanceMessage_Public_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100675289);
			DealGenerationEvent.NativeMethodInfoPtr_GetProductStringList_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100675290);
			DealGenerationEvent.NativeMethodInfoPtr_GetQualityString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100675291);
			DealGenerationEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100675292);
		}

		// Token: 0x06005D39 RID: 23865 RVA: 0x001B29A8 File Offset: 0x001B0BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197669, XrefRangeEnd = 197674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContractInfo GenerateContractInfo(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr_GenerateContractInfo_Public_ContractInfo_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContractInfo>(intPtr2) : null;
		}

		// Token: 0x06005D3A RID: 23866 RVA: 0x001B29F8 File Offset: 0x001B0BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197674, XrefRangeEnd = 197697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldGenerate(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr_ShouldGenerate_Public_Boolean_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005D3B RID: 23867 RVA: 0x001B2A48 File Offset: 0x001B0C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197697, XrefRangeEnd = 197701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageChain GetRandomRequestMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr_GetRandomRequestMessage_Public_MessageChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr2) : null;
		}

		// Token: 0x06005D3C RID: 23868 RVA: 0x001B2A88 File Offset: 0x001B0C88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 197752, RefRangeEnd = 197755, XrefRangeStart = 197701, XrefRangeEnd = 197752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageChain ProcessMessage(MessageChain messageChain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(messageChain);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr_ProcessMessage_Public_MessageChain_MessageChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr2) : null;
		}

		// Token: 0x06005D3D RID: 23869 RVA: 0x001B2AD8 File Offset: 0x001B0CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197755, XrefRangeEnd = 197759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageChain GetRejectionMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr_GetRejectionMessage_Public_MessageChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr2) : null;
		}

		// Token: 0x06005D3E RID: 23870 RVA: 0x001B2B18 File Offset: 0x001B0D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197759, XrefRangeEnd = 197763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageChain GetAcceptanceMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr_GetAcceptanceMessage_Public_MessageChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr2) : null;
		}

		// Token: 0x06005D3F RID: 23871 RVA: 0x001B2B58 File Offset: 0x001B0D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197763, XrefRangeEnd = 197765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetProductStringList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr_GetProductStringList_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06005D40 RID: 23872 RVA: 0x001B2B90 File Offset: 0x001B0D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197765, XrefRangeEnd = 197767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetQualityString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr_GetQualityString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06005D41 RID: 23873 RVA: 0x001B2BC8 File Offset: 0x001B0DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197767, XrefRangeEnd = 197775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealGenerationEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005D42 RID: 23874 RVA: 0x0002BB68 File Offset: 0x00029D68
		public DealGenerationEvent(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BD9 RID: 7129
		// (get) Token: 0x06005D43 RID: 23875 RVA: 0x001B2C04 File Offset: 0x001B0E04
		// (set) Token: 0x06005D44 RID: 23876 RVA: 0x0002BB71 File Offset: 0x00029D71
		public unsafe bool Enabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_Enabled)) = value;
			}
		}

		// Token: 0x17001BDA RID: 7130
		// (get) Token: 0x06005D45 RID: 23877 RVA: 0x001B2C2C File Offset: 0x001B0E2C
		// (set) Token: 0x06005D46 RID: 23878 RVA: 0x0002BB8C File Offset: 0x00029D8C
		public unsafe bool CanBeAccepted
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_CanBeAccepted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_CanBeAccepted)) = value;
			}
		}

		// Token: 0x17001BDB RID: 7131
		// (get) Token: 0x06005D47 RID: 23879 RVA: 0x001B2C54 File Offset: 0x001B0E54
		// (set) Token: 0x06005D48 RID: 23880 RVA: 0x0002BBA7 File Offset: 0x00029DA7
		public unsafe bool CanBeRejected
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_CanBeRejected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_CanBeRejected)) = value;
			}
		}

		// Token: 0x17001BDC RID: 7132
		// (get) Token: 0x06005D49 RID: 23881 RVA: 0x001B2C7C File Offset: 0x001B0E7C
		// (set) Token: 0x06005D4A RID: 23882 RVA: 0x0002BBC2 File Offset: 0x00029DC2
		public unsafe List<DealGenerationEvent.DayContainer> ApplicableDays
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ApplicableDays);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DealGenerationEvent.DayContainer>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ApplicableDays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BDD RID: 7133
		// (get) Token: 0x06005D4B RID: 23883 RVA: 0x001B2CAC File Offset: 0x001B0EAC
		// (set) Token: 0x06005D4C RID: 23884 RVA: 0x0002BBE1 File Offset: 0x00029DE1
		public unsafe int GenerationTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_GenerationTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_GenerationTime)) = value;
			}
		}

		// Token: 0x17001BDE RID: 7134
		// (get) Token: 0x06005D4D RID: 23885 RVA: 0x001B2CD4 File Offset: 0x001B0ED4
		// (set) Token: 0x06005D4E RID: 23886 RVA: 0x0002BBFC File Offset: 0x00029DFC
		public unsafe int GenerationWindowDuration
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_GenerationWindowDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_GenerationWindowDuration)) = value;
			}
		}

		// Token: 0x17001BDF RID: 7135
		// (get) Token: 0x06005D4F RID: 23887 RVA: 0x001B2CFC File Offset: 0x001B0EFC
		// (set) Token: 0x06005D50 RID: 23888 RVA: 0x0002BC17 File Offset: 0x00029E17
		public unsafe ProductList ProductList
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ProductList);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductList>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ProductList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BE0 RID: 7136
		// (get) Token: 0x06005D51 RID: 23889 RVA: 0x001B2D2C File Offset: 0x001B0F2C
		// (set) Token: 0x06005D52 RID: 23890 RVA: 0x0002BC36 File Offset: 0x00029E36
		public unsafe float Payment
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_Payment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_Payment)) = value;
			}
		}

		// Token: 0x17001BE1 RID: 7137
		// (get) Token: 0x06005D53 RID: 23891 RVA: 0x001B2D54 File Offset: 0x001B0F54
		// (set) Token: 0x06005D54 RID: 23892 RVA: 0x0002BC51 File Offset: 0x00029E51
		public unsafe float RelationshipRequirement
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_RelationshipRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_RelationshipRequirement)) = value;
			}
		}

		// Token: 0x17001BE2 RID: 7138
		// (get) Token: 0x06005D55 RID: 23893 RVA: 0x001B2D7C File Offset: 0x001B0F7C
		// (set) Token: 0x06005D56 RID: 23894 RVA: 0x0002BC6C File Offset: 0x00029E6C
		public unsafe Il2CppReferenceArray<MessageChain> RequestMessageChains
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_RequestMessageChains);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MessageChain>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_RequestMessageChains), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BE3 RID: 7139
		// (get) Token: 0x06005D57 RID: 23895 RVA: 0x001B2DAC File Offset: 0x001B0FAC
		// (set) Token: 0x06005D58 RID: 23896 RVA: 0x0002BC8B File Offset: 0x00029E8B
		public unsafe Il2CppReferenceArray<MessageChain> ContractAcceptedResponses
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ContractAcceptedResponses);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MessageChain>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ContractAcceptedResponses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BE4 RID: 7140
		// (get) Token: 0x06005D59 RID: 23897 RVA: 0x001B2DDC File Offset: 0x001B0FDC
		// (set) Token: 0x06005D5A RID: 23898 RVA: 0x0002BCAA File Offset: 0x00029EAA
		public unsafe Il2CppReferenceArray<MessageChain> ContractRejectedResponses
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ContractRejectedResponses);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MessageChain>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ContractRejectedResponses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BE5 RID: 7141
		// (get) Token: 0x06005D5B RID: 23899 RVA: 0x001B2E0C File Offset: 0x001B100C
		// (set) Token: 0x06005D5C RID: 23900 RVA: 0x0002BCC9 File Offset: 0x00029EC9
		public unsafe DeliveryLocation DeliveryLocation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_DeliveryLocation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryLocation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_DeliveryLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BE6 RID: 7142
		// (get) Token: 0x06005D5D RID: 23901 RVA: 0x001B2E3C File Offset: 0x001B103C
		// (set) Token: 0x06005D5E RID: 23902 RVA: 0x0002BCE8 File Offset: 0x00029EE8
		public unsafe int PickupScheduleGroup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_PickupScheduleGroup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_PickupScheduleGroup)) = value;
			}
		}

		// Token: 0x17001BE7 RID: 7143
		// (get) Token: 0x06005D5F RID: 23903 RVA: 0x001B2E64 File Offset: 0x001B1064
		// (set) Token: 0x06005D60 RID: 23904 RVA: 0x0002BD03 File Offset: 0x00029F03
		public unsafe QuestWindowConfig DeliveryWindow
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_DeliveryWindow);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestWindowConfig>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_DeliveryWindow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BE8 RID: 7144
		// (get) Token: 0x06005D61 RID: 23905 RVA: 0x001B2E94 File Offset: 0x001B1094
		// (set) Token: 0x06005D62 RID: 23906 RVA: 0x0002BD22 File Offset: 0x00029F22
		public unsafe bool Expires
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_Expires);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_Expires)) = value;
			}
		}

		// Token: 0x17001BE9 RID: 7145
		// (get) Token: 0x06005D63 RID: 23907 RVA: 0x001B2EBC File Offset: 0x001B10BC
		// (set) Token: 0x06005D64 RID: 23908 RVA: 0x0002BD3D File Offset: 0x00029F3D
		public unsafe int ExpiresAfter
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ExpiresAfter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ExpiresAfter)) = value;
			}
		}

		// Token: 0x04003FBD RID: 16317
		private static readonly System.IntPtr NativeFieldInfoPtr_Enabled;

		// Token: 0x04003FBE RID: 16318
		private static readonly System.IntPtr NativeFieldInfoPtr_CanBeAccepted;

		// Token: 0x04003FBF RID: 16319
		private static readonly System.IntPtr NativeFieldInfoPtr_CanBeRejected;

		// Token: 0x04003FC0 RID: 16320
		private static readonly System.IntPtr NativeFieldInfoPtr_ApplicableDays;

		// Token: 0x04003FC1 RID: 16321
		private static readonly System.IntPtr NativeFieldInfoPtr_GenerationTime;

		// Token: 0x04003FC2 RID: 16322
		private static readonly System.IntPtr NativeFieldInfoPtr_GenerationWindowDuration;

		// Token: 0x04003FC3 RID: 16323
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductList;

		// Token: 0x04003FC4 RID: 16324
		private static readonly System.IntPtr NativeFieldInfoPtr_Payment;

		// Token: 0x04003FC5 RID: 16325
		private static readonly System.IntPtr NativeFieldInfoPtr_RelationshipRequirement;

		// Token: 0x04003FC6 RID: 16326
		private static readonly System.IntPtr NativeFieldInfoPtr_RequestMessageChains;

		// Token: 0x04003FC7 RID: 16327
		private static readonly System.IntPtr NativeFieldInfoPtr_ContractAcceptedResponses;

		// Token: 0x04003FC8 RID: 16328
		private static readonly System.IntPtr NativeFieldInfoPtr_ContractRejectedResponses;

		// Token: 0x04003FC9 RID: 16329
		private static readonly System.IntPtr NativeFieldInfoPtr_DeliveryLocation;

		// Token: 0x04003FCA RID: 16330
		private static readonly System.IntPtr NativeFieldInfoPtr_PickupScheduleGroup;

		// Token: 0x04003FCB RID: 16331
		private static readonly System.IntPtr NativeFieldInfoPtr_DeliveryWindow;

		// Token: 0x04003FCC RID: 16332
		private static readonly System.IntPtr NativeFieldInfoPtr_Expires;

		// Token: 0x04003FCD RID: 16333
		private static readonly System.IntPtr NativeFieldInfoPtr_ExpiresAfter;

		// Token: 0x04003FCE RID: 16334
		private static readonly System.IntPtr NativeMethodInfoPtr_GenerateContractInfo_Public_ContractInfo_Customer_0;

		// Token: 0x04003FCF RID: 16335
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldGenerate_Public_Boolean_Customer_0;

		// Token: 0x04003FD0 RID: 16336
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomRequestMessage_Public_MessageChain_0;

		// Token: 0x04003FD1 RID: 16337
		private static readonly System.IntPtr NativeMethodInfoPtr_ProcessMessage_Public_MessageChain_MessageChain_0;

		// Token: 0x04003FD2 RID: 16338
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRejectionMessage_Public_MessageChain_0;

		// Token: 0x04003FD3 RID: 16339
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAcceptanceMessage_Public_MessageChain_0;

		// Token: 0x04003FD4 RID: 16340
		private static readonly System.IntPtr NativeMethodInfoPtr_GetProductStringList_Public_String_0;

		// Token: 0x04003FD5 RID: 16341
		private static readonly System.IntPtr NativeMethodInfoPtr_GetQualityString_Public_String_0;

		// Token: 0x04003FD6 RID: 16342
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A35 RID: 2613
		[System.Serializable]
		public class DayContainer : Il2CppSystem.Object
		{
			// Token: 0x0600D297 RID: 53911 RVA: 0x0032D788 File Offset: 0x0032B988
			// Note: this type is marked as 'beforefieldinit'.
			static DayContainer()
			{
				Il2CppClassPointerStore<DealGenerationEvent.DayContainer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "DayContainer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealGenerationEvent.DayContainer>.NativeClassPtr);
				DealGenerationEvent.DayContainer.NativeFieldInfoPtr_Day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent.DayContainer>.NativeClassPtr, "Day");
				DealGenerationEvent.DayContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent.DayContainer>.NativeClassPtr, 100675293);
			}

			// Token: 0x0600D298 RID: 53912 RVA: 0x0032D7DC File Offset: 0x0032B9DC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DayContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealGenerationEvent.DayContainer>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.DayContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D299 RID: 53913 RVA: 0x000661A2 File Offset: 0x000643A2
			public DayContainer(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700413B RID: 16699
			// (get) Token: 0x0600D29A RID: 53914 RVA: 0x0032D818 File Offset: 0x0032BA18
			// (set) Token: 0x0600D29B RID: 53915 RVA: 0x000661AB File Offset: 0x000643AB
			public unsafe EDay Day
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.DayContainer.NativeFieldInfoPtr_Day);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.DayContainer.NativeFieldInfoPtr_Day)) = value;
				}
			}

			// Token: 0x04008E4D RID: 36429
			private static readonly System.IntPtr NativeFieldInfoPtr_Day;

			// Token: 0x04008E4E RID: 36430
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A36 RID: 2614
		[ObfuscatedName("ScheduleOne.Economy.DealGenerationEvent+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D29C RID: 53916 RVA: 0x0032D840 File Offset: 0x0032BA40
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DealGenerationEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealGenerationEvent.__c>.NativeClassPtr);
				DealGenerationEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent.__c>.NativeClassPtr, "<>9");
				DealGenerationEvent.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent.__c>.NativeClassPtr, "<>9__19_0");
				DealGenerationEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent.__c>.NativeClassPtr, 100675295);
				DealGenerationEvent.__c.NativeMethodInfoPtr__ShouldGenerate_b__19_0_Internal_Boolean_DayContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent.__c>.NativeClassPtr, 100675296);
			}

			// Token: 0x0600D29D RID: 53917 RVA: 0x0032D8BC File Offset: 0x0032BABC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealGenerationEvent.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D29E RID: 53918 RVA: 0x0032D8F8 File Offset: 0x0032BAF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197664, XrefRangeEnd = 197669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ShouldGenerate_b__19_0(DealGenerationEvent.DayContainer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.__c.NativeMethodInfoPtr__ShouldGenerate_b__19_0_Internal_Boolean_DayContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D29F RID: 53919 RVA: 0x000661C6 File Offset: 0x000643C6
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700413C RID: 16700
			// (get) Token: 0x0600D2A0 RID: 53920 RVA: 0x0032D948 File Offset: 0x0032BB48
			// (set) Token: 0x0600D2A1 RID: 53921 RVA: 0x000661CF File Offset: 0x000643CF
			public unsafe static DealGenerationEvent.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DealGenerationEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealGenerationEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DealGenerationEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700413D RID: 16701
			// (get) Token: 0x0600D2A2 RID: 53922 RVA: 0x0032D970 File Offset: 0x0032BB70
			// (set) Token: 0x0600D2A3 RID: 53923 RVA: 0x000661E1 File Offset: 0x000643E1
			public unsafe static Il2CppSystem.Predicate<DealGenerationEvent.DayContainer> __9__19_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DealGenerationEvent.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<DealGenerationEvent.DayContainer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DealGenerationEvent.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E4F RID: 36431
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008E50 RID: 36432
			private static readonly System.IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x04008E51 RID: 36433
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E52 RID: 36434
			private static readonly System.IntPtr NativeMethodInfoPtr__ShouldGenerate_b__19_0_Internal_Boolean_DayContainer_0;
		}
	}
}
