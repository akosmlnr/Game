using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.Quests;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000273 RID: 627
	public class CustomerData : SaveData
	{
		// Token: 0x06002FE0 RID: 12256 RVA: 0x0010CD3C File Offset: 0x0010AF3C
		// Note: this type is marked as 'beforefieldinit'.
		static CustomerData()
		{
			Il2CppClassPointerStore<CustomerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "CustomerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerData>.NativeClassPtr);
			CustomerData.NativeFieldInfoPtr_Dependence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "Dependence");
			CustomerData.NativeFieldInfoPtr_PurchaseableProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "PurchaseableProducts");
			CustomerData.NativeFieldInfoPtr_ProductAffinities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "ProductAffinities");
			CustomerData.NativeFieldInfoPtr_TimeSinceLastDealCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "TimeSinceLastDealCompleted");
			CustomerData.NativeFieldInfoPtr_TimeSinceLastDealOffered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "TimeSinceLastDealOffered");
			CustomerData.NativeFieldInfoPtr_OfferedDeals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "OfferedDeals");
			CustomerData.NativeFieldInfoPtr_CompletedDeals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "CompletedDeals");
			CustomerData.NativeFieldInfoPtr_IsContractOffered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "IsContractOffered");
			CustomerData.NativeFieldInfoPtr_OfferedContract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "OfferedContract");
			CustomerData.NativeFieldInfoPtr_OfferedContractTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "OfferedContractTime");
			CustomerData.NativeFieldInfoPtr_TimeSincePlayerApproached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "TimeSincePlayerApproached");
			CustomerData.NativeFieldInfoPtr_TimeSinceInstantDealOffered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "TimeSinceInstantDealOffered");
			CustomerData.NativeFieldInfoPtr_HasBeenRecommended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "HasBeenRecommended");
			CustomerData.NativeMethodInfoPtr__ctor_Public_Void_Single_Il2CppStringArray_Il2CppStructArray_1_Single_Int32_Int32_Int32_Int32_Boolean_ContractInfo_GameDateTime_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100668958);
			CustomerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100668959);
		}

		// Token: 0x06002FE1 RID: 12257 RVA: 0x0010CE98 File Offset: 0x0010B098
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136224, RefRangeEnd = 136225, XrefRangeStart = 136220, XrefRangeEnd = 136224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerData(float dependence, Il2CppStringArray purchaseableProducts, Il2CppStructArray<float> productAffinities, int timeSinceLastDealCompleted, int timeSinceLastDealOffered, int offeredDeals, int completedDeals, bool isContractOffered, ContractInfo offeredContract, GameDateTime offeredTime, int timeSincePlayerApproached, int timeSinceInstantDealOffered, bool hasBeenRecommended) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dependence;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(purchaseableProducts);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productAffinities);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeSinceLastDealCompleted;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeSinceLastDealOffered;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offeredDeals;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref completedDeals;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isContractOffered;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(offeredContract);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offeredTime;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeSincePlayerApproached;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeSinceInstantDealOffered;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasBeenRecommended;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr__ctor_Public_Void_Single_Il2CppStringArray_Il2CppStructArray_1_Single_Int32_Int32_Int32_Int32_Boolean_ContractInfo_GameDateTime_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002FE2 RID: 12258 RVA: 0x0010CF9C File Offset: 0x0010B19C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136226, RefRangeEnd = 136227, XrefRangeStart = 136225, XrefRangeEnd = 136226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerData>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002FE3 RID: 12259 RVA: 0x0001905C File Offset: 0x0001725C
		public CustomerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x06002FE4 RID: 12260 RVA: 0x0010CFD8 File Offset: 0x0010B1D8
		// (set) Token: 0x06002FE5 RID: 12261 RVA: 0x00019065 File Offset: 0x00017265
		public unsafe float Dependence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_Dependence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_Dependence)) = value;
			}
		}

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x06002FE6 RID: 12262 RVA: 0x0010D000 File Offset: 0x0010B200
		// (set) Token: 0x06002FE7 RID: 12263 RVA: 0x00019080 File Offset: 0x00017280
		public unsafe Il2CppStringArray PurchaseableProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_PurchaseableProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_PurchaseableProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x06002FE8 RID: 12264 RVA: 0x0010D030 File Offset: 0x0010B230
		// (set) Token: 0x06002FE9 RID: 12265 RVA: 0x0001909F File Offset: 0x0001729F
		public unsafe Il2CppStructArray<float> ProductAffinities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_ProductAffinities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_ProductAffinities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06002FEA RID: 12266 RVA: 0x0010D060 File Offset: 0x0010B260
		// (set) Token: 0x06002FEB RID: 12267 RVA: 0x000190BE File Offset: 0x000172BE
		public unsafe int TimeSinceLastDealCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_TimeSinceLastDealCompleted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_TimeSinceLastDealCompleted)) = value;
			}
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06002FEC RID: 12268 RVA: 0x0010D088 File Offset: 0x0010B288
		// (set) Token: 0x06002FED RID: 12269 RVA: 0x000190D9 File Offset: 0x000172D9
		public unsafe int TimeSinceLastDealOffered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_TimeSinceLastDealOffered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_TimeSinceLastDealOffered)) = value;
			}
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x06002FEE RID: 12270 RVA: 0x0010D0B0 File Offset: 0x0010B2B0
		// (set) Token: 0x06002FEF RID: 12271 RVA: 0x000190F4 File Offset: 0x000172F4
		public unsafe int OfferedDeals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OfferedDeals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OfferedDeals)) = value;
			}
		}

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x06002FF0 RID: 12272 RVA: 0x0010D0D8 File Offset: 0x0010B2D8
		// (set) Token: 0x06002FF1 RID: 12273 RVA: 0x0001910F File Offset: 0x0001730F
		public unsafe int CompletedDeals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_CompletedDeals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_CompletedDeals)) = value;
			}
		}

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x06002FF2 RID: 12274 RVA: 0x0010D100 File Offset: 0x0010B300
		// (set) Token: 0x06002FF3 RID: 12275 RVA: 0x0001912A File Offset: 0x0001732A
		public unsafe bool IsContractOffered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_IsContractOffered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_IsContractOffered)) = value;
			}
		}

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x06002FF4 RID: 12276 RVA: 0x0010D128 File Offset: 0x0010B328
		// (set) Token: 0x06002FF5 RID: 12277 RVA: 0x00019145 File Offset: 0x00017345
		public unsafe ContractInfo OfferedContract
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OfferedContract);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContractInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OfferedContract), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x06002FF6 RID: 12278 RVA: 0x0010D158 File Offset: 0x0010B358
		// (set) Token: 0x06002FF7 RID: 12279 RVA: 0x00019164 File Offset: 0x00017364
		public unsafe GameDateTime OfferedContractTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OfferedContractTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OfferedContractTime)) = value;
			}
		}

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x06002FF8 RID: 12280 RVA: 0x0010D180 File Offset: 0x0010B380
		// (set) Token: 0x06002FF9 RID: 12281 RVA: 0x0001917F File Offset: 0x0001737F
		public unsafe int TimeSincePlayerApproached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_TimeSincePlayerApproached);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_TimeSincePlayerApproached)) = value;
			}
		}

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x06002FFA RID: 12282 RVA: 0x0010D1A8 File Offset: 0x0010B3A8
		// (set) Token: 0x06002FFB RID: 12283 RVA: 0x0001919A File Offset: 0x0001739A
		public unsafe int TimeSinceInstantDealOffered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_TimeSinceInstantDealOffered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_TimeSinceInstantDealOffered)) = value;
			}
		}

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x06002FFC RID: 12284 RVA: 0x0010D1D0 File Offset: 0x0010B3D0
		// (set) Token: 0x06002FFD RID: 12285 RVA: 0x000191B5 File Offset: 0x000173B5
		public unsafe bool HasBeenRecommended
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_HasBeenRecommended);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_HasBeenRecommended)) = value;
			}
		}

		// Token: 0x04001FB5 RID: 8117
		private static readonly IntPtr NativeFieldInfoPtr_Dependence;

		// Token: 0x04001FB6 RID: 8118
		private static readonly IntPtr NativeFieldInfoPtr_PurchaseableProducts;

		// Token: 0x04001FB7 RID: 8119
		private static readonly IntPtr NativeFieldInfoPtr_ProductAffinities;

		// Token: 0x04001FB8 RID: 8120
		private static readonly IntPtr NativeFieldInfoPtr_TimeSinceLastDealCompleted;

		// Token: 0x04001FB9 RID: 8121
		private static readonly IntPtr NativeFieldInfoPtr_TimeSinceLastDealOffered;

		// Token: 0x04001FBA RID: 8122
		private static readonly IntPtr NativeFieldInfoPtr_OfferedDeals;

		// Token: 0x04001FBB RID: 8123
		private static readonly IntPtr NativeFieldInfoPtr_CompletedDeals;

		// Token: 0x04001FBC RID: 8124
		private static readonly IntPtr NativeFieldInfoPtr_IsContractOffered;

		// Token: 0x04001FBD RID: 8125
		private static readonly IntPtr NativeFieldInfoPtr_OfferedContract;

		// Token: 0x04001FBE RID: 8126
		private static readonly IntPtr NativeFieldInfoPtr_OfferedContractTime;

		// Token: 0x04001FBF RID: 8127
		private static readonly IntPtr NativeFieldInfoPtr_TimeSincePlayerApproached;

		// Token: 0x04001FC0 RID: 8128
		private static readonly IntPtr NativeFieldInfoPtr_TimeSinceInstantDealOffered;

		// Token: 0x04001FC1 RID: 8129
		private static readonly IntPtr NativeFieldInfoPtr_HasBeenRecommended;

		// Token: 0x04001FC2 RID: 8130
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Il2CppStringArray_Il2CppStructArray_1_Single_Int32_Int32_Int32_Int32_Boolean_ContractInfo_GameDateTime_Int32_Int32_Boolean_0;

		// Token: 0x04001FC3 RID: 8131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
