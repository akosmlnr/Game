using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002BA RID: 698
	public class PotData : GridItemData
	{
		// Token: 0x06003229 RID: 12841 RVA: 0x00113670 File Offset: 0x00111870
		// Note: this type is marked as 'beforefieldinit'.
		static PotData()
		{
			Il2CppClassPointerStore<PotData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PotData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotData>.NativeClassPtr);
			PotData.NativeFieldInfoPtr_SoilID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotData>.NativeClassPtr, "SoilID");
			PotData.NativeFieldInfoPtr_SoilLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotData>.NativeClassPtr, "SoilLevel");
			PotData.NativeFieldInfoPtr_RemainingSoilUses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotData>.NativeClassPtr, "RemainingSoilUses");
			PotData.NativeFieldInfoPtr_WaterLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotData>.NativeClassPtr, "WaterLevel");
			PotData.NativeFieldInfoPtr_AppliedAdditives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotData>.NativeClassPtr, "AppliedAdditives");
			PotData.NativeFieldInfoPtr_PlantData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotData>.NativeClassPtr, "PlantData");
			PotData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_String_Single_Int32_Single_Il2CppStringArray_PlantData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotData>.NativeClassPtr, 100669064);
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x0011372C File Offset: 0x0011192C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136986, RefRangeEnd = 136987, XrefRangeStart = 136976, XrefRangeEnd = 136986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotData(Il2CppSystem.Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, string soilID, float soilLevel, int remainingSoilUses, float waterLevel, Il2CppStringArray appliedAdditives, PlantData plantData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)12) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(soilID);
			ptr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref soilLevel;
			ptr[checked(unchecked((System.UIntPtr)8) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref remainingSoilUses;
			ptr[checked(unchecked((System.UIntPtr)9) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref waterLevel;
			ptr[checked(unchecked((System.UIntPtr)10) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(appliedAdditives);
			ptr[checked(unchecked((System.UIntPtr)11) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(plantData);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_String_Single_Int32_Single_Il2CppStringArray_PlantData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600322B RID: 12843 RVA: 0x0001A7CC File Offset: 0x000189CC
		public PotData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x0600322C RID: 12844 RVA: 0x0011382C File Offset: 0x00111A2C
		// (set) Token: 0x0600322D RID: 12845 RVA: 0x0001A7D5 File Offset: 0x000189D5
		public unsafe string SoilID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_SoilID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_SoilID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x0600322E RID: 12846 RVA: 0x00113854 File Offset: 0x00111A54
		// (set) Token: 0x0600322F RID: 12847 RVA: 0x0001A7F4 File Offset: 0x000189F4
		public unsafe float SoilLevel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_SoilLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_SoilLevel)) = value;
			}
		}

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x06003230 RID: 12848 RVA: 0x0011387C File Offset: 0x00111A7C
		// (set) Token: 0x06003231 RID: 12849 RVA: 0x0001A80F File Offset: 0x00018A0F
		public unsafe int RemainingSoilUses
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_RemainingSoilUses);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_RemainingSoilUses)) = value;
			}
		}

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x06003232 RID: 12850 RVA: 0x001138A4 File Offset: 0x00111AA4
		// (set) Token: 0x06003233 RID: 12851 RVA: 0x0001A82A File Offset: 0x00018A2A
		public unsafe float WaterLevel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_WaterLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_WaterLevel)) = value;
			}
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x06003234 RID: 12852 RVA: 0x001138CC File Offset: 0x00111ACC
		// (set) Token: 0x06003235 RID: 12853 RVA: 0x0001A845 File Offset: 0x00018A45
		public unsafe Il2CppStringArray AppliedAdditives
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_AppliedAdditives);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_AppliedAdditives), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x06003236 RID: 12854 RVA: 0x001138FC File Offset: 0x00111AFC
		// (set) Token: 0x06003237 RID: 12855 RVA: 0x0001A864 File Offset: 0x00018A64
		public unsafe PlantData PlantData
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_PlantData);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlantData>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_PlantData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020C1 RID: 8385
		private static readonly System.IntPtr NativeFieldInfoPtr_SoilID;

		// Token: 0x040020C2 RID: 8386
		private static readonly System.IntPtr NativeFieldInfoPtr_SoilLevel;

		// Token: 0x040020C3 RID: 8387
		private static readonly System.IntPtr NativeFieldInfoPtr_RemainingSoilUses;

		// Token: 0x040020C4 RID: 8388
		private static readonly System.IntPtr NativeFieldInfoPtr_WaterLevel;

		// Token: 0x040020C5 RID: 8389
		private static readonly System.IntPtr NativeFieldInfoPtr_AppliedAdditives;

		// Token: 0x040020C6 RID: 8390
		private static readonly System.IntPtr NativeFieldInfoPtr_PlantData;

		// Token: 0x040020C7 RID: 8391
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_String_Single_Int32_Single_Il2CppStringArray_PlantData_0;
	}
}
