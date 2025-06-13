using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x020006A2 RID: 1698
	public class StationRecipeEntry : MonoBehaviour
	{
		// Token: 0x060096D2 RID: 38610 RVA: 0x0026E120 File Offset: 0x0026C320
		// Note: this type is marked as 'beforefieldinit'.
		static StationRecipeEntry()
		{
			Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "StationRecipeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr);
			StationRecipeEntry.NativeFieldInfoPtr_ValidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "ValidColor");
			StationRecipeEntry.NativeFieldInfoPtr_InvalidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "InvalidColor");
			StationRecipeEntry.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "Button");
			StationRecipeEntry.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "Icon");
			StationRecipeEntry.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "TitleLabel");
			StationRecipeEntry.NativeFieldInfoPtr_CookingTimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "CookingTimeLabel");
			StationRecipeEntry.NativeFieldInfoPtr_IngredientRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "IngredientRects");
			StationRecipeEntry.NativeFieldInfoPtr_IngredientQuantities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "IngredientQuantities");
			StationRecipeEntry.NativeFieldInfoPtr__IsValid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "<IsValid>k__BackingField");
			StationRecipeEntry.NativeFieldInfoPtr__Recipe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "<Recipe>k__BackingField");
			StationRecipeEntry.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100682062);
			StationRecipeEntry.NativeMethodInfoPtr_set_IsValid_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100682063);
			StationRecipeEntry.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100682064);
			StationRecipeEntry.NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100682065);
			StationRecipeEntry.NativeMethodInfoPtr_AssignRecipe_Public_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100682066);
			StationRecipeEntry.NativeMethodInfoPtr_RefreshValidity_Public_Void_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100682067);
			StationRecipeEntry.NativeMethodInfoPtr_GetIngredientsMatchDelta_Public_Single_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100682068);
			StationRecipeEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100682069);
		}

		// Token: 0x17002E1E RID: 11806
		// (get) Token: 0x060096D3 RID: 38611 RVA: 0x0026E2B8 File Offset: 0x0026C4B8
		// (set) Token: 0x060096D4 RID: 38612 RVA: 0x0026E2F4 File Offset: 0x0026C4F4
		public unsafe bool IsValid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_set_IsValid_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002E1F RID: 11807
		// (get) Token: 0x060096D5 RID: 38613 RVA: 0x0026E334 File Offset: 0x0026C534
		// (set) Token: 0x060096D6 RID: 38614 RVA: 0x0026E374 File Offset: 0x0026C574
		public unsafe StationRecipe Recipe
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060096D7 RID: 38615 RVA: 0x0026E3B8 File Offset: 0x0026C5B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 271045, RefRangeEnd = 271049, XrefRangeStart = 270980, XrefRangeEnd = 271045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignRecipe(StationRecipe recipe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_AssignRecipe_Public_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060096D8 RID: 38616 RVA: 0x0026E3FC File Offset: 0x0026C5FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 271112, RefRangeEnd = 271114, XrefRangeStart = 271049, XrefRangeEnd = 271112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshValidity(List<ItemInstance> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_RefreshValidity_Public_Void_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060096D9 RID: 38617 RVA: 0x0026E440 File Offset: 0x0026C640
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271184, RefRangeEnd = 271185, XrefRangeStart = 271114, XrefRangeEnd = 271184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetIngredientsMatchDelta(List<ItemInstance> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_GetIngredientsMatchDelta_Public_Single_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060096DA RID: 38618 RVA: 0x0026E490 File Offset: 0x0026C690
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationRecipeEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060096DB RID: 38619 RVA: 0x00048F59 File Offset: 0x00047159
		public StationRecipeEntry(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E14 RID: 11796
		// (get) Token: 0x060096DC RID: 38620 RVA: 0x0026E4CC File Offset: 0x0026C6CC
		// (set) Token: 0x060096DD RID: 38621 RVA: 0x00048F62 File Offset: 0x00047162
		public unsafe static Color ValidColor
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(StationRecipeEntry.NativeFieldInfoPtr_ValidColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StationRecipeEntry.NativeFieldInfoPtr_ValidColor, (void*)(&value));
			}
		}

		// Token: 0x17002E15 RID: 11797
		// (get) Token: 0x060096DE RID: 38622 RVA: 0x0026E4E8 File Offset: 0x0026C6E8
		// (set) Token: 0x060096DF RID: 38623 RVA: 0x00048F70 File Offset: 0x00047170
		public unsafe static Color InvalidColor
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(StationRecipeEntry.NativeFieldInfoPtr_InvalidColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StationRecipeEntry.NativeFieldInfoPtr_InvalidColor, (void*)(&value));
			}
		}

		// Token: 0x17002E16 RID: 11798
		// (get) Token: 0x060096E0 RID: 38624 RVA: 0x0026E504 File Offset: 0x0026C704
		// (set) Token: 0x060096E1 RID: 38625 RVA: 0x00048F7E File Offset: 0x0004717E
		public unsafe Button Button
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_Button);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E17 RID: 11799
		// (get) Token: 0x060096E2 RID: 38626 RVA: 0x0026E534 File Offset: 0x0026C734
		// (set) Token: 0x060096E3 RID: 38627 RVA: 0x00048F9D File Offset: 0x0004719D
		public unsafe Image Icon
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_Icon);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E18 RID: 11800
		// (get) Token: 0x060096E4 RID: 38628 RVA: 0x0026E564 File Offset: 0x0026C764
		// (set) Token: 0x060096E5 RID: 38629 RVA: 0x00048FBC File Offset: 0x000471BC
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_TitleLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E19 RID: 11801
		// (get) Token: 0x060096E6 RID: 38630 RVA: 0x0026E594 File Offset: 0x0026C794
		// (set) Token: 0x060096E7 RID: 38631 RVA: 0x00048FDB File Offset: 0x000471DB
		public unsafe TextMeshProUGUI CookingTimeLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_CookingTimeLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_CookingTimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E1A RID: 11802
		// (get) Token: 0x060096E8 RID: 38632 RVA: 0x0026E5C4 File Offset: 0x0026C7C4
		// (set) Token: 0x060096E9 RID: 38633 RVA: 0x00048FFA File Offset: 0x000471FA
		public unsafe Il2CppReferenceArray<RectTransform> IngredientRects
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_IngredientRects);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_IngredientRects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E1B RID: 11803
		// (get) Token: 0x060096EA RID: 38634 RVA: 0x0026E5F4 File Offset: 0x0026C7F4
		// (set) Token: 0x060096EB RID: 38635 RVA: 0x00049019 File Offset: 0x00047219
		public unsafe Il2CppReferenceArray<TextMeshProUGUI> IngredientQuantities
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_IngredientQuantities);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_IngredientQuantities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E1C RID: 11804
		// (get) Token: 0x060096EC RID: 38636 RVA: 0x0026E624 File Offset: 0x0026C824
		// (set) Token: 0x060096ED RID: 38637 RVA: 0x00049038 File Offset: 0x00047238
		public unsafe bool _IsValid_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr__IsValid_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr__IsValid_k__BackingField)) = value;
			}
		}

		// Token: 0x17002E1D RID: 11805
		// (get) Token: 0x060096EE RID: 38638 RVA: 0x0026E64C File Offset: 0x0026C84C
		// (set) Token: 0x060096EF RID: 38639 RVA: 0x00049053 File Offset: 0x00047253
		public unsafe StationRecipe _Recipe_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr__Recipe_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr__Recipe_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040065C6 RID: 26054
		private static readonly System.IntPtr NativeFieldInfoPtr_ValidColor;

		// Token: 0x040065C7 RID: 26055
		private static readonly System.IntPtr NativeFieldInfoPtr_InvalidColor;

		// Token: 0x040065C8 RID: 26056
		private static readonly System.IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x040065C9 RID: 26057
		private static readonly System.IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x040065CA RID: 26058
		private static readonly System.IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x040065CB RID: 26059
		private static readonly System.IntPtr NativeFieldInfoPtr_CookingTimeLabel;

		// Token: 0x040065CC RID: 26060
		private static readonly System.IntPtr NativeFieldInfoPtr_IngredientRects;

		// Token: 0x040065CD RID: 26061
		private static readonly System.IntPtr NativeFieldInfoPtr_IngredientQuantities;

		// Token: 0x040065CE RID: 26062
		private static readonly System.IntPtr NativeFieldInfoPtr__IsValid_k__BackingField;

		// Token: 0x040065CF RID: 26063
		private static readonly System.IntPtr NativeFieldInfoPtr__Recipe_k__BackingField;

		// Token: 0x040065D0 RID: 26064
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;

		// Token: 0x040065D1 RID: 26065
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsValid_Private_set_Void_Boolean_0;

		// Token: 0x040065D2 RID: 26066
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0;

		// Token: 0x040065D3 RID: 26067
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0;

		// Token: 0x040065D4 RID: 26068
		private static readonly System.IntPtr NativeMethodInfoPtr_AssignRecipe_Public_Void_StationRecipe_0;

		// Token: 0x040065D5 RID: 26069
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshValidity_Public_Void_List_1_ItemInstance_0;

		// Token: 0x040065D6 RID: 26070
		private static readonly System.IntPtr NativeMethodInfoPtr_GetIngredientsMatchDelta_Public_Single_List_1_ItemInstance_0;

		// Token: 0x040065D7 RID: 26071
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BA9 RID: 2985
		[ObfuscatedName("ScheduleOne.UI.Stations.StationRecipeEntry+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DF4E RID: 57166 RVA: 0x003515B0 File Offset: 0x0034F7B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr);
				StationRecipeEntry.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr, "<>9");
				StationRecipeEntry.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr, "<>9__18_0");
				StationRecipeEntry.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr, 100682072);
				StationRecipeEntry.__c.NativeMethodInfoPtr__GetIngredientsMatchDelta_b__18_0_Internal_Int32_IngredientQuantity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr, 100682073);
			}

			// Token: 0x0600DF4F RID: 57167 RVA: 0x0035162C File Offset: 0x0034F82C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DF50 RID: 57168 RVA: 0x00351668 File Offset: 0x0034F868
			[CallerCount(0)]
			public unsafe int _GetIngredientsMatchDelta_b__18_0(StationRecipe.IngredientQuantity x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.__c.NativeMethodInfoPtr__GetIngredientsMatchDelta_b__18_0_Internal_Int32_IngredientQuantity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DF51 RID: 57169 RVA: 0x0006C6C2 File Offset: 0x0006A8C2
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044F9 RID: 17657
			// (get) Token: 0x0600DF52 RID: 57170 RVA: 0x003516B8 File Offset: 0x0034F8B8
			// (set) Token: 0x0600DF53 RID: 57171 RVA: 0x0006C6CB File Offset: 0x0006A8CB
			public unsafe static StationRecipeEntry.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationRecipeEntry.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationRecipeEntry.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044FA RID: 17658
			// (get) Token: 0x0600DF54 RID: 57172 RVA: 0x003516E0 File Offset: 0x0034F8E0
			// (set) Token: 0x0600DF55 RID: 57173 RVA: 0x0006C6DD File Offset: 0x0006A8DD
			public unsafe static Il2CppSystem.Func<StationRecipe.IngredientQuantity, int> __9__18_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationRecipeEntry.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<StationRecipe.IngredientQuantity, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationRecipeEntry.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009604 RID: 38404
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009605 RID: 38405
			private static readonly System.IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x04009606 RID: 38406
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009607 RID: 38407
			private static readonly System.IntPtr NativeMethodInfoPtr__GetIngredientsMatchDelta_b__18_0_Internal_Int32_IngredientQuantity_0;
		}

		// Token: 0x02000BAA RID: 2986
		[ObfuscatedName("ScheduleOne.UI.Stations.StationRecipeEntry+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DF56 RID: 57174 RVA: 0x00351708 File Offset: 0x0034F908
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass17_0>.NativeClassPtr);
				StationRecipeEntry.__c__DisplayClass17_0.NativeFieldInfoPtr_ingredientVariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass17_0>.NativeClassPtr, "ingredientVariant");
				StationRecipeEntry.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass17_0>.NativeClassPtr, 100682074);
				StationRecipeEntry.__c__DisplayClass17_0.NativeMethodInfoPtr__RefreshValidity_b__0_Internal_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass17_0>.NativeClassPtr, 100682075);
			}

			// Token: 0x0600DF57 RID: 57175 RVA: 0x00351770 File Offset: 0x0034F970
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass17_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DF58 RID: 57176 RVA: 0x003517AC File Offset: 0x0034F9AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RefreshValidity_b__0(ItemInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.__c__DisplayClass17_0.NativeMethodInfoPtr__RefreshValidity_b__0_Internal_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DF59 RID: 57177 RVA: 0x0006C6EF File Offset: 0x0006A8EF
			public __c__DisplayClass17_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044FB RID: 17659
			// (get) Token: 0x0600DF5A RID: 57178 RVA: 0x003517FC File Offset: 0x0034F9FC
			// (set) Token: 0x0600DF5B RID: 57179 RVA: 0x0006C6F8 File Offset: 0x0006A8F8
			public unsafe ItemDefinition ingredientVariant
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.__c__DisplayClass17_0.NativeFieldInfoPtr_ingredientVariant);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.__c__DisplayClass17_0.NativeFieldInfoPtr_ingredientVariant), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009608 RID: 38408
			private static readonly System.IntPtr NativeFieldInfoPtr_ingredientVariant;

			// Token: 0x04009609 RID: 38409
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400960A RID: 38410
			private static readonly System.IntPtr NativeMethodInfoPtr__RefreshValidity_b__0_Internal_Boolean_ItemInstance_0;
		}

		// Token: 0x02000BAB RID: 2987
		[ObfuscatedName("ScheduleOne.UI.Stations.StationRecipeEntry+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DF5C RID: 57180 RVA: 0x0035182C File Offset: 0x0034FA2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass18_0>.NativeClassPtr);
				StationRecipeEntry.__c__DisplayClass18_0.NativeFieldInfoPtr_ingredientVariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass18_0>.NativeClassPtr, "ingredientVariant");
				StationRecipeEntry.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass18_0>.NativeClassPtr, 100682076);
				StationRecipeEntry.__c__DisplayClass18_0.NativeMethodInfoPtr__GetIngredientsMatchDelta_b__1_Internal_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass18_0>.NativeClassPtr, 100682077);
			}

			// Token: 0x0600DF5D RID: 57181 RVA: 0x00351894 File Offset: 0x0034FA94
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass18_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DF5E RID: 57182 RVA: 0x003518D0 File Offset: 0x0034FAD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetIngredientsMatchDelta_b__1(ItemInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.__c__DisplayClass18_0.NativeMethodInfoPtr__GetIngredientsMatchDelta_b__1_Internal_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DF5F RID: 57183 RVA: 0x0006C717 File Offset: 0x0006A917
			public __c__DisplayClass18_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044FC RID: 17660
			// (get) Token: 0x0600DF60 RID: 57184 RVA: 0x00351920 File Offset: 0x0034FB20
			// (set) Token: 0x0600DF61 RID: 57185 RVA: 0x0006C720 File Offset: 0x0006A920
			public unsafe ItemDefinition ingredientVariant
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.__c__DisplayClass18_0.NativeFieldInfoPtr_ingredientVariant);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.__c__DisplayClass18_0.NativeFieldInfoPtr_ingredientVariant), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400960B RID: 38411
			private static readonly System.IntPtr NativeFieldInfoPtr_ingredientVariant;

			// Token: 0x0400960C RID: 38412
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400960D RID: 38413
			private static readonly System.IntPtr NativeMethodInfoPtr__GetIngredientsMatchDelta_b__1_Internal_Boolean_ItemInstance_0;
		}
	}
}
