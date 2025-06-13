using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002C3 RID: 707
	[Serializable]
	public class PlantData : SaveData
	{
		// Token: 0x06003268 RID: 12904 RVA: 0x001142FC File Offset: 0x001124FC
		// Note: this type is marked as 'beforefieldinit'.
		static PlantData()
		{
			Il2CppClassPointerStore<PlantData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PlantData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlantData>.NativeClassPtr);
			PlantData.NativeFieldInfoPtr_SeedID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantData>.NativeClassPtr, "SeedID");
			PlantData.NativeFieldInfoPtr_GrowthProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantData>.NativeClassPtr, "GrowthProgress");
			PlantData.NativeFieldInfoPtr_YieldLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantData>.NativeClassPtr, "YieldLevel");
			PlantData.NativeFieldInfoPtr_QualityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantData>.NativeClassPtr, "QualityLevel");
			PlantData.NativeFieldInfoPtr_ActiveBuds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantData>.NativeClassPtr, "ActiveBuds");
			PlantData.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Single_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantData>.NativeClassPtr, 100669073);
		}

		// Token: 0x06003269 RID: 12905 RVA: 0x001143A4 File Offset: 0x001125A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137017, RefRangeEnd = 137018, XrefRangeStart = 137014, XrefRangeEnd = 137017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlantData(string seedID, float growthProgress, float yieldLevel, float qualityLevel, Il2CppStructArray<int> activeBuds) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlantData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref growthProgress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qualityLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeBuds);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlantData.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Single_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600326A RID: 12906 RVA: 0x0001AA27 File Offset: 0x00018C27
		public PlantData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x0600326B RID: 12907 RVA: 0x0011442C File Offset: 0x0011262C
		// (set) Token: 0x0600326C RID: 12908 RVA: 0x0001AA30 File Offset: 0x00018C30
		public unsafe string SeedID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_SeedID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_SeedID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x0600326D RID: 12909 RVA: 0x00114454 File Offset: 0x00112654
		// (set) Token: 0x0600326E RID: 12910 RVA: 0x0001AA4F File Offset: 0x00018C4F
		public unsafe float GrowthProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_GrowthProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_GrowthProgress)) = value;
			}
		}

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x0600326F RID: 12911 RVA: 0x0011447C File Offset: 0x0011267C
		// (set) Token: 0x06003270 RID: 12912 RVA: 0x0001AA6A File Offset: 0x00018C6A
		public unsafe float YieldLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_YieldLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_YieldLevel)) = value;
			}
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x06003271 RID: 12913 RVA: 0x001144A4 File Offset: 0x001126A4
		// (set) Token: 0x06003272 RID: 12914 RVA: 0x0001AA85 File Offset: 0x00018C85
		public unsafe float QualityLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_QualityLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_QualityLevel)) = value;
			}
		}

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x06003273 RID: 12915 RVA: 0x001144CC File Offset: 0x001126CC
		// (set) Token: 0x06003274 RID: 12916 RVA: 0x0001AAA0 File Offset: 0x00018CA0
		public unsafe Il2CppStructArray<int> ActiveBuds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_ActiveBuds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_ActiveBuds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020DC RID: 8412
		private static readonly IntPtr NativeFieldInfoPtr_SeedID;

		// Token: 0x040020DD RID: 8413
		private static readonly IntPtr NativeFieldInfoPtr_GrowthProgress;

		// Token: 0x040020DE RID: 8414
		private static readonly IntPtr NativeFieldInfoPtr_YieldLevel;

		// Token: 0x040020DF RID: 8415
		private static readonly IntPtr NativeFieldInfoPtr_QualityLevel;

		// Token: 0x040020E0 RID: 8416
		private static readonly IntPtr NativeFieldInfoPtr_ActiveBuds;

		// Token: 0x040020E1 RID: 8417
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Single_Il2CppStructArray_1_Int32_0;
	}
}
