using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B1 RID: 689
	public class ChemistryStationData : GridItemData
	{
		// Token: 0x060031D4 RID: 12756 RVA: 0x001125A4 File Offset: 0x001107A4
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistryStationData()
		{
			Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ChemistryStationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr);
			ChemistryStationData.NativeFieldInfoPtr_InputContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr, "InputContents");
			ChemistryStationData.NativeFieldInfoPtr_OutputContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr, "OutputContents");
			ChemistryStationData.NativeFieldInfoPtr_CurrentRecipeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr, "CurrentRecipeID");
			ChemistryStationData.NativeFieldInfoPtr_ProductQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr, "ProductQuality");
			ChemistryStationData.NativeFieldInfoPtr_StartLiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr, "StartLiquidColor");
			ChemistryStationData.NativeFieldInfoPtr_LiquidLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr, "LiquidLevel");
			ChemistryStationData.NativeFieldInfoPtr_CurrentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr, "CurrentTime");
			ChemistryStationData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_String_EQuality_Color_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr, 100669055);
		}

		// Token: 0x060031D5 RID: 12757 RVA: 0x00112674 File Offset: 0x00110874
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136925, RefRangeEnd = 136926, XrefRangeStart = 136916, XrefRangeEnd = 136925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryStationData(Il2CppSystem.Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet inputContents, ItemSet outputContents, string currentRecipeID, EQuality productQuality, Color startLiquidColor, float liquidLevel, int currentTime) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)13) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputContents);
			ptr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outputContents);
			ptr[checked(unchecked((System.UIntPtr)8) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(currentRecipeID);
			ptr[checked(unchecked((System.UIntPtr)9) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref productQuality;
			ptr[checked(unchecked((System.UIntPtr)10) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref startLiquidColor;
			ptr[checked(unchecked((System.UIntPtr)11) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref liquidLevel;
			ptr[checked(unchecked((System.UIntPtr)12) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref currentTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_String_EQuality_Color_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060031D6 RID: 12758 RVA: 0x0001A420 File Offset: 0x00018620
		public ChemistryStationData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x060031D7 RID: 12759 RVA: 0x00112780 File Offset: 0x00110980
		// (set) Token: 0x060031D8 RID: 12760 RVA: 0x0001A429 File Offset: 0x00018629
		public unsafe ItemSet InputContents
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_InputContents);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_InputContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x060031D9 RID: 12761 RVA: 0x001127B0 File Offset: 0x001109B0
		// (set) Token: 0x060031DA RID: 12762 RVA: 0x0001A448 File Offset: 0x00018648
		public unsafe ItemSet OutputContents
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_OutputContents);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_OutputContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x060031DB RID: 12763 RVA: 0x001127E0 File Offset: 0x001109E0
		// (set) Token: 0x060031DC RID: 12764 RVA: 0x0001A467 File Offset: 0x00018667
		public unsafe string CurrentRecipeID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_CurrentRecipeID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_CurrentRecipeID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x060031DD RID: 12765 RVA: 0x00112808 File Offset: 0x00110A08
		// (set) Token: 0x060031DE RID: 12766 RVA: 0x0001A486 File Offset: 0x00018686
		public unsafe EQuality ProductQuality
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_ProductQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_ProductQuality)) = value;
			}
		}

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x060031DF RID: 12767 RVA: 0x00112830 File Offset: 0x00110A30
		// (set) Token: 0x060031E0 RID: 12768 RVA: 0x0001A4A1 File Offset: 0x000186A1
		public unsafe Color StartLiquidColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_StartLiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_StartLiquidColor)) = value;
			}
		}

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x060031E1 RID: 12769 RVA: 0x00112858 File Offset: 0x00110A58
		// (set) Token: 0x060031E2 RID: 12770 RVA: 0x0001A4BC File Offset: 0x000186BC
		public unsafe float LiquidLevel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_LiquidLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_LiquidLevel)) = value;
			}
		}

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x060031E3 RID: 12771 RVA: 0x00112880 File Offset: 0x00110A80
		// (set) Token: 0x060031E4 RID: 12772 RVA: 0x0001A4D7 File Offset: 0x000186D7
		public unsafe int CurrentTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_CurrentTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_CurrentTime)) = value;
			}
		}

		// Token: 0x0400209B RID: 8347
		private static readonly System.IntPtr NativeFieldInfoPtr_InputContents;

		// Token: 0x0400209C RID: 8348
		private static readonly System.IntPtr NativeFieldInfoPtr_OutputContents;

		// Token: 0x0400209D RID: 8349
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentRecipeID;

		// Token: 0x0400209E RID: 8350
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductQuality;

		// Token: 0x0400209F RID: 8351
		private static readonly System.IntPtr NativeFieldInfoPtr_StartLiquidColor;

		// Token: 0x040020A0 RID: 8352
		private static readonly System.IntPtr NativeFieldInfoPtr_LiquidLevel;

		// Token: 0x040020A1 RID: 8353
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentTime;

		// Token: 0x040020A2 RID: 8354
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_String_EQuality_Color_Single_Int32_0;
	}
}
