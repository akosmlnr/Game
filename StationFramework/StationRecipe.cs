using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Storage;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x020005B5 RID: 1461
	[System.Serializable]
	public class StationRecipe : ScriptableObject
	{
		// Token: 0x06007FA4 RID: 32676 RVA: 0x00225318 File Offset: 0x00223518
		// Note: this type is marked as 'beforefieldinit'.
		static StationRecipe()
		{
			Il2CppClassPointerStore<StationRecipe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "StationRecipe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr);
			StationRecipe.NativeFieldInfoPtr_IsDiscovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "IsDiscovered");
			StationRecipe.NativeFieldInfoPtr_RecipeTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "RecipeTitle");
			StationRecipe.NativeFieldInfoPtr_Unlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "Unlocked");
			StationRecipe.NativeFieldInfoPtr_Ingredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "Ingredients");
			StationRecipe.NativeFieldInfoPtr_Product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "Product");
			StationRecipe.NativeFieldInfoPtr_FinalLiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "FinalLiquidColor");
			StationRecipe.NativeFieldInfoPtr_CookTime_Mins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "CookTime_Mins");
			StationRecipe.NativeFieldInfoPtr_CookTemperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "CookTemperature");
			StationRecipe.NativeFieldInfoPtr_CookTemperatureTolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "CookTemperatureTolerance");
			StationRecipe.NativeFieldInfoPtr_QualityCalculationMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "QualityCalculationMethod");
			StationRecipe.NativeMethodInfoPtr_get_CookTemperatureLowerBound_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679363);
			StationRecipe.NativeMethodInfoPtr_get_CookTemperatureUpperBound_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679364);
			StationRecipe.NativeMethodInfoPtr_get_RecipeID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679365);
			StationRecipe.NativeMethodInfoPtr_GetProductInstance_Public_StorableItemInstance_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679366);
			StationRecipe.NativeMethodInfoPtr_GetProductInstance_Public_StorableItemInstance_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679367);
			StationRecipe.NativeMethodInfoPtr_DoIngredientsSuffice_Public_Boolean_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679368);
			StationRecipe.NativeMethodInfoPtr_CalculateQuality_Public_EQuality_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679369);
			StationRecipe.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679370);
		}

		// Token: 0x17002677 RID: 9847
		// (get) Token: 0x06007FA5 RID: 32677 RVA: 0x002254B0 File Offset: 0x002236B0
		public unsafe float CookTemperatureLowerBound
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 241889, RefRangeEnd = 241891, XrefRangeStart = 241889, XrefRangeEnd = 241889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_get_CookTemperatureLowerBound_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002678 RID: 9848
		// (get) Token: 0x06007FA6 RID: 32678 RVA: 0x002254EC File Offset: 0x002236EC
		public unsafe float CookTemperatureUpperBound
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 241891, RefRangeEnd = 241896, XrefRangeStart = 241891, XrefRangeEnd = 241891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_get_CookTemperatureUpperBound_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002679 RID: 9849
		// (get) Token: 0x06007FA7 RID: 32679 RVA: 0x00225528 File Offset: 0x00223728
		public unsafe string RecipeID
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 241901, RefRangeEnd = 241905, XrefRangeStart = 241896, XrefRangeEnd = 241901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_get_RecipeID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x06007FA8 RID: 32680 RVA: 0x00225560 File Offset: 0x00223760
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 241912, RefRangeEnd = 241915, XrefRangeStart = 241905, XrefRangeEnd = 241912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorableItemInstance GetProductInstance(List<ItemInstance> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_GetProductInstance_Public_StorableItemInstance_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr2) : null;
		}

		// Token: 0x06007FA9 RID: 32681 RVA: 0x002255B0 File Offset: 0x002237B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241919, RefRangeEnd = 241920, XrefRangeStart = 241915, XrefRangeEnd = 241919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorableItemInstance GetProductInstance(EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref quality;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_GetProductInstance_Public_StorableItemInstance_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr2) : null;
		}

		// Token: 0x06007FAA RID: 32682 RVA: 0x002255FC File Offset: 0x002237FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241972, RefRangeEnd = 241973, XrefRangeStart = 241920, XrefRangeEnd = 241972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoIngredientsSuffice(List<ItemInstance> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_DoIngredientsSuffice_Public_Boolean_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007FAB RID: 32683 RVA: 0x0022564C File Offset: 0x0022384C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 241986, RefRangeEnd = 241989, XrefRangeStart = 241973, XrefRangeEnd = 241986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EQuality CalculateQuality(List<ItemInstance> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_CalculateQuality_Public_EQuality_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007FAC RID: 32684 RVA: 0x0022569C File Offset: 0x0022389C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241989, XrefRangeEnd = 241997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationRecipe() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007FAD RID: 32685 RVA: 0x0003C679 File Offset: 0x0003A879
		public StationRecipe(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700266D RID: 9837
		// (get) Token: 0x06007FAE RID: 32686 RVA: 0x002256D8 File Offset: 0x002238D8
		// (set) Token: 0x06007FAF RID: 32687 RVA: 0x0003C682 File Offset: 0x0003A882
		public unsafe bool IsDiscovered
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_IsDiscovered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_IsDiscovered)) = value;
			}
		}

		// Token: 0x1700266E RID: 9838
		// (get) Token: 0x06007FB0 RID: 32688 RVA: 0x00225700 File Offset: 0x00223900
		// (set) Token: 0x06007FB1 RID: 32689 RVA: 0x0003C69D File Offset: 0x0003A89D
		public unsafe string RecipeTitle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_RecipeTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_RecipeTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700266F RID: 9839
		// (get) Token: 0x06007FB2 RID: 32690 RVA: 0x00225728 File Offset: 0x00223928
		// (set) Token: 0x06007FB3 RID: 32691 RVA: 0x0003C6BC File Offset: 0x0003A8BC
		public unsafe bool Unlocked
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_Unlocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_Unlocked)) = value;
			}
		}

		// Token: 0x17002670 RID: 9840
		// (get) Token: 0x06007FB4 RID: 32692 RVA: 0x00225750 File Offset: 0x00223950
		// (set) Token: 0x06007FB5 RID: 32693 RVA: 0x0003C6D7 File Offset: 0x0003A8D7
		public unsafe List<StationRecipe.IngredientQuantity> Ingredients
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_Ingredients);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipe.IngredientQuantity>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_Ingredients), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002671 RID: 9841
		// (get) Token: 0x06007FB6 RID: 32694 RVA: 0x00225780 File Offset: 0x00223980
		// (set) Token: 0x06007FB7 RID: 32695 RVA: 0x0003C6F6 File Offset: 0x0003A8F6
		public unsafe StationRecipe.ItemQuantity Product
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_Product);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe.ItemQuantity>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_Product), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002672 RID: 9842
		// (get) Token: 0x06007FB8 RID: 32696 RVA: 0x002257B0 File Offset: 0x002239B0
		// (set) Token: 0x06007FB9 RID: 32697 RVA: 0x0003C715 File Offset: 0x0003A915
		public unsafe Color FinalLiquidColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_FinalLiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_FinalLiquidColor)) = value;
			}
		}

		// Token: 0x17002673 RID: 9843
		// (get) Token: 0x06007FBA RID: 32698 RVA: 0x002257D8 File Offset: 0x002239D8
		// (set) Token: 0x06007FBB RID: 32699 RVA: 0x0003C730 File Offset: 0x0003A930
		public unsafe int CookTime_Mins
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_CookTime_Mins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_CookTime_Mins)) = value;
			}
		}

		// Token: 0x17002674 RID: 9844
		// (get) Token: 0x06007FBC RID: 32700 RVA: 0x00225800 File Offset: 0x00223A00
		// (set) Token: 0x06007FBD RID: 32701 RVA: 0x0003C74B File Offset: 0x0003A94B
		public unsafe float CookTemperature
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_CookTemperature);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_CookTemperature)) = value;
			}
		}

		// Token: 0x17002675 RID: 9845
		// (get) Token: 0x06007FBE RID: 32702 RVA: 0x00225828 File Offset: 0x00223A28
		// (set) Token: 0x06007FBF RID: 32703 RVA: 0x0003C766 File Offset: 0x0003A966
		public unsafe float CookTemperatureTolerance
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_CookTemperatureTolerance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_CookTemperatureTolerance)) = value;
			}
		}

		// Token: 0x17002676 RID: 9846
		// (get) Token: 0x06007FC0 RID: 32704 RVA: 0x00225850 File Offset: 0x00223A50
		// (set) Token: 0x06007FC1 RID: 32705 RVA: 0x0003C781 File Offset: 0x0003A981
		public unsafe StationRecipe.EQualityCalculationMethod QualityCalculationMethod
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_QualityCalculationMethod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_QualityCalculationMethod)) = value;
			}
		}

		// Token: 0x040056DB RID: 22235
		private static readonly System.IntPtr NativeFieldInfoPtr_IsDiscovered;

		// Token: 0x040056DC RID: 22236
		private static readonly System.IntPtr NativeFieldInfoPtr_RecipeTitle;

		// Token: 0x040056DD RID: 22237
		private static readonly System.IntPtr NativeFieldInfoPtr_Unlocked;

		// Token: 0x040056DE RID: 22238
		private static readonly System.IntPtr NativeFieldInfoPtr_Ingredients;

		// Token: 0x040056DF RID: 22239
		private static readonly System.IntPtr NativeFieldInfoPtr_Product;

		// Token: 0x040056E0 RID: 22240
		private static readonly System.IntPtr NativeFieldInfoPtr_FinalLiquidColor;

		// Token: 0x040056E1 RID: 22241
		private static readonly System.IntPtr NativeFieldInfoPtr_CookTime_Mins;

		// Token: 0x040056E2 RID: 22242
		private static readonly System.IntPtr NativeFieldInfoPtr_CookTemperature;

		// Token: 0x040056E3 RID: 22243
		private static readonly System.IntPtr NativeFieldInfoPtr_CookTemperatureTolerance;

		// Token: 0x040056E4 RID: 22244
		private static readonly System.IntPtr NativeFieldInfoPtr_QualityCalculationMethod;

		// Token: 0x040056E5 RID: 22245
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CookTemperatureLowerBound_Public_get_Single_0;

		// Token: 0x040056E6 RID: 22246
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CookTemperatureUpperBound_Public_get_Single_0;

		// Token: 0x040056E7 RID: 22247
		private static readonly System.IntPtr NativeMethodInfoPtr_get_RecipeID_Public_get_String_0;

		// Token: 0x040056E8 RID: 22248
		private static readonly System.IntPtr NativeMethodInfoPtr_GetProductInstance_Public_StorableItemInstance_List_1_ItemInstance_0;

		// Token: 0x040056E9 RID: 22249
		private static readonly System.IntPtr NativeMethodInfoPtr_GetProductInstance_Public_StorableItemInstance_EQuality_0;

		// Token: 0x040056EA RID: 22250
		private static readonly System.IntPtr NativeMethodInfoPtr_DoIngredientsSuffice_Public_Boolean_List_1_ItemInstance_0;

		// Token: 0x040056EB RID: 22251
		private static readonly System.IntPtr NativeMethodInfoPtr_CalculateQuality_Public_EQuality_List_1_ItemInstance_0;

		// Token: 0x040056EC RID: 22252
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B0E RID: 2830
		[OriginalName("Assembly-CSharp.dll", "", "EQualityCalculationMethod")]
		public enum EQualityCalculationMethod
		{
			// Token: 0x0400924A RID: 37450
			Additive
		}

		// Token: 0x02000B0F RID: 2831
		[System.Serializable]
		public class ItemQuantity : Il2CppSystem.Object
		{
			// Token: 0x0600D923 RID: 55587 RVA: 0x0033FA0C File Offset: 0x0033DC0C
			// Note: this type is marked as 'beforefieldinit'.
			static ItemQuantity()
			{
				Il2CppClassPointerStore<StationRecipe.ItemQuantity>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "ItemQuantity");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipe.ItemQuantity>.NativeClassPtr);
				StationRecipe.ItemQuantity.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe.ItemQuantity>.NativeClassPtr, "Item");
				StationRecipe.ItemQuantity.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe.ItemQuantity>.NativeClassPtr, "Quantity");
				StationRecipe.ItemQuantity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe.ItemQuantity>.NativeClassPtr, 100679371);
			}

			// Token: 0x0600D924 RID: 55588 RVA: 0x0033FA74 File Offset: 0x0033DC74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241861, XrefRangeEnd = 241862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ItemQuantity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipe.ItemQuantity>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.ItemQuantity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D925 RID: 55589 RVA: 0x000695D6 File Offset: 0x000677D6
			public ItemQuantity(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004303 RID: 17155
			// (get) Token: 0x0600D926 RID: 55590 RVA: 0x0033FAB0 File Offset: 0x0033DCB0
			// (set) Token: 0x0600D927 RID: 55591 RVA: 0x000695DF File Offset: 0x000677DF
			public unsafe ItemDefinition Item
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.ItemQuantity.NativeFieldInfoPtr_Item);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.ItemQuantity.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004304 RID: 17156
			// (get) Token: 0x0600D928 RID: 55592 RVA: 0x0033FAE0 File Offset: 0x0033DCE0
			// (set) Token: 0x0600D929 RID: 55593 RVA: 0x000695FE File Offset: 0x000677FE
			public unsafe int Quantity
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.ItemQuantity.NativeFieldInfoPtr_Quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.ItemQuantity.NativeFieldInfoPtr_Quantity)) = value;
				}
			}

			// Token: 0x0400924B RID: 37451
			private static readonly System.IntPtr NativeFieldInfoPtr_Item;

			// Token: 0x0400924C RID: 37452
			private static readonly System.IntPtr NativeFieldInfoPtr_Quantity;

			// Token: 0x0400924D RID: 37453
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B10 RID: 2832
		[System.Serializable]
		public class IngredientQuantity : Il2CppSystem.Object
		{
			// Token: 0x0600D92A RID: 55594 RVA: 0x0033FB08 File Offset: 0x0033DD08
			// Note: this type is marked as 'beforefieldinit'.
			static IngredientQuantity()
			{
				Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "IngredientQuantity");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr);
				StationRecipe.IngredientQuantity.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr, "Items");
				StationRecipe.IngredientQuantity.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr, "Quantity");
				StationRecipe.IngredientQuantity.NativeMethodInfoPtr_get_Item_Public_get_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr, 100679372);
				StationRecipe.IngredientQuantity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr, 100679373);
			}

			// Token: 0x17004307 RID: 17159
			// (get) Token: 0x0600D92B RID: 55595 RVA: 0x0033FB84 File Offset: 0x0033DD84
			public unsafe ItemDefinition Item
			{
				[CallerCount(12)]
				[CachedScanResults(RefRangeStart = 241865, RefRangeEnd = 241877, XrefRangeStart = 241862, XrefRangeEnd = 241865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.IngredientQuantity.NativeMethodInfoPtr_get_Item_Public_get_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
			}

			// Token: 0x0600D92C RID: 55596 RVA: 0x0033FBC4 File Offset: 0x0033DDC4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 241885, RefRangeEnd = 241887, XrefRangeStart = 241877, XrefRangeEnd = 241885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IngredientQuantity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.IngredientQuantity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D92D RID: 55597 RVA: 0x00069619 File Offset: 0x00067819
			public IngredientQuantity(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004305 RID: 17157
			// (get) Token: 0x0600D92E RID: 55598 RVA: 0x0033FC00 File Offset: 0x0033DE00
			// (set) Token: 0x0600D92F RID: 55599 RVA: 0x00069622 File Offset: 0x00067822
			public unsafe List<ItemDefinition> Items
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.IngredientQuantity.NativeFieldInfoPtr_Items);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemDefinition>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.IngredientQuantity.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004306 RID: 17158
			// (get) Token: 0x0600D930 RID: 55600 RVA: 0x0033FC30 File Offset: 0x0033DE30
			// (set) Token: 0x0600D931 RID: 55601 RVA: 0x00069641 File Offset: 0x00067841
			public unsafe int Quantity
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.IngredientQuantity.NativeFieldInfoPtr_Quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.IngredientQuantity.NativeFieldInfoPtr_Quantity)) = value;
				}
			}

			// Token: 0x0400924E RID: 37454
			private static readonly System.IntPtr NativeFieldInfoPtr_Items;

			// Token: 0x0400924F RID: 37455
			private static readonly System.IntPtr NativeFieldInfoPtr_Quantity;

			// Token: 0x04009250 RID: 37456
			private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_ItemDefinition_0;

			// Token: 0x04009251 RID: 37457
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B11 RID: 2833
		[ObfuscatedName("ScheduleOne.StationFramework.StationRecipe+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D932 RID: 55602 RVA: 0x0033FC58 File Offset: 0x0033DE58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<StationRecipe.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipe.__c__DisplayClass21_0>.NativeClassPtr);
				StationRecipe.__c__DisplayClass21_0.NativeFieldInfoPtr_ingredientVariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe.__c__DisplayClass21_0>.NativeClassPtr, "ingredientVariant");
				StationRecipe.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe.__c__DisplayClass21_0>.NativeClassPtr, 100679374);
				StationRecipe.__c__DisplayClass21_0.NativeMethodInfoPtr__DoIngredientsSuffice_b__0_Internal_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe.__c__DisplayClass21_0>.NativeClassPtr, 100679375);
			}

			// Token: 0x0600D933 RID: 55603 RVA: 0x0033FCC0 File Offset: 0x0033DEC0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipe.__c__DisplayClass21_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D934 RID: 55604 RVA: 0x0033FCFC File Offset: 0x0033DEFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241887, XrefRangeEnd = 241889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DoIngredientsSuffice_b__0(ItemInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StationRecipe.__c__DisplayClass21_0.NativeMethodInfoPtr__DoIngredientsSuffice_b__0_Internal_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D935 RID: 55605 RVA: 0x0006965C File Offset: 0x0006785C
			public __c__DisplayClass21_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004308 RID: 17160
			// (get) Token: 0x0600D936 RID: 55606 RVA: 0x0033FD4C File Offset: 0x0033DF4C
			// (set) Token: 0x0600D937 RID: 55607 RVA: 0x00069665 File Offset: 0x00067865
			public unsafe ItemDefinition ingredientVariant
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.__c__DisplayClass21_0.NativeFieldInfoPtr_ingredientVariant);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.__c__DisplayClass21_0.NativeFieldInfoPtr_ingredientVariant), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009252 RID: 37458
			private static readonly System.IntPtr NativeFieldInfoPtr_ingredientVariant;

			// Token: 0x04009253 RID: 37459
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009254 RID: 37460
			private static readonly System.IntPtr NativeMethodInfoPtr__DoIngredientsSuffice_b__0_Internal_Boolean_ItemInstance_0;
		}
	}
}
