using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.StationFramework;
using Il2CppScheduleOne.UI.Stations;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006F3 RID: 1779
	public class StationRecipeFieldUI : MonoBehaviour
	{
		// Token: 0x06009EF0 RID: 40688 RVA: 0x002864F4 File Offset: 0x002846F4
		// Note: this type is marked as 'beforefieldinit'.
		static StationRecipeFieldUI()
		{
			Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "StationRecipeFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr);
			StationRecipeFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			StationRecipeFieldUI.NativeFieldInfoPtr_RecipeEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, "RecipeEntry");
			StationRecipeFieldUI.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, "None");
			StationRecipeFieldUI.NativeFieldInfoPtr_Mixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, "Mixed");
			StationRecipeFieldUI.NativeFieldInfoPtr_ClearButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, "ClearButton");
			StationRecipeFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_StationRecipeField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682908);
			StationRecipeFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_StationRecipeField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682909);
			StationRecipeFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_StationRecipeField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682910);
			StationRecipeFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682911);
			StationRecipeFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682912);
			StationRecipeFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682913);
			StationRecipeFieldUI.NativeMethodInfoPtr_OptionSelected_Private_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682914);
			StationRecipeFieldUI.NativeMethodInfoPtr_ClearClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682915);
			StationRecipeFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682916);
		}

		// Token: 0x170030C2 RID: 12482
		// (get) Token: 0x06009EF1 RID: 40689 RVA: 0x0028663C File Offset: 0x0028483C
		// (set) Token: 0x06009EF2 RID: 40690 RVA: 0x0028667C File Offset: 0x0028487C
		public unsafe List<StationRecipeField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_StationRecipeField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipeField>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_StationRecipeField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009EF3 RID: 40691 RVA: 0x002866C0 File Offset: 0x002848C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281973, XrefRangeEnd = 282000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<StationRecipeField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_StationRecipeField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EF4 RID: 40692 RVA: 0x00286704 File Offset: 0x00284904
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282026, RefRangeEnd = 282028, XrefRangeStart = 282000, XrefRangeEnd = 282026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(StationRecipe newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVal);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EF5 RID: 40693 RVA: 0x00286748 File Offset: 0x00284948
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282039, RefRangeEnd = 282041, XrefRangeStart = 282028, XrefRangeEnd = 282039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009EF6 RID: 40694 RVA: 0x00286784 File Offset: 0x00284984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282041, XrefRangeEnd = 282085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EF7 RID: 40695 RVA: 0x002867B8 File Offset: 0x002849B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282085, XrefRangeEnd = 282100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionSelected(StationRecipe option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_OptionSelected_Private_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EF8 RID: 40696 RVA: 0x002867FC File Offset: 0x002849FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282100, XrefRangeEnd = 282115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_ClearClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EF9 RID: 40697 RVA: 0x00286830 File Offset: 0x00284A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282115, XrefRangeEnd = 282123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationRecipeFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EFA RID: 40698 RVA: 0x0004DAE8 File Offset: 0x0004BCE8
		public StationRecipeFieldUI(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030BD RID: 12477
		// (get) Token: 0x06009EFB RID: 40699 RVA: 0x0028686C File Offset: 0x00284A6C
		// (set) Token: 0x06009EFC RID: 40700 RVA: 0x0004DAF1 File Offset: 0x0004BCF1
		public unsafe List<StationRecipeField> _Fields_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipeField>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030BE RID: 12478
		// (get) Token: 0x06009EFD RID: 40701 RVA: 0x0028689C File Offset: 0x00284A9C
		// (set) Token: 0x06009EFE RID: 40702 RVA: 0x0004DB10 File Offset: 0x0004BD10
		public unsafe StationRecipeEntry RecipeEntry
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_RecipeEntry);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_RecipeEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030BF RID: 12479
		// (get) Token: 0x06009EFF RID: 40703 RVA: 0x002868CC File Offset: 0x00284ACC
		// (set) Token: 0x06009F00 RID: 40704 RVA: 0x0004DB2F File Offset: 0x0004BD2F
		public unsafe GameObject None
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_None);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_None), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030C0 RID: 12480
		// (get) Token: 0x06009F01 RID: 40705 RVA: 0x002868FC File Offset: 0x00284AFC
		// (set) Token: 0x06009F02 RID: 40706 RVA: 0x0004DB4E File Offset: 0x0004BD4E
		public unsafe GameObject Mixed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_Mixed);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_Mixed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030C1 RID: 12481
		// (get) Token: 0x06009F03 RID: 40707 RVA: 0x0028692C File Offset: 0x00284B2C
		// (set) Token: 0x06009F04 RID: 40708 RVA: 0x0004DB6D File Offset: 0x0004BD6D
		public unsafe GameObject ClearButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_ClearButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_ClearButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006AC8 RID: 27336
		private static readonly System.IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x04006AC9 RID: 27337
		private static readonly System.IntPtr NativeFieldInfoPtr_RecipeEntry;

		// Token: 0x04006ACA RID: 27338
		private static readonly System.IntPtr NativeFieldInfoPtr_None;

		// Token: 0x04006ACB RID: 27339
		private static readonly System.IntPtr NativeFieldInfoPtr_Mixed;

		// Token: 0x04006ACC RID: 27340
		private static readonly System.IntPtr NativeFieldInfoPtr_ClearButton;

		// Token: 0x04006ACD RID: 27341
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_StationRecipeField_0;

		// Token: 0x04006ACE RID: 27342
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_StationRecipeField_0;

		// Token: 0x04006ACF RID: 27343
		private static readonly System.IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_StationRecipeField_0;

		// Token: 0x04006AD0 RID: 27344
		private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Private_Void_StationRecipe_0;

		// Token: 0x04006AD1 RID: 27345
		private static readonly System.IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x04006AD2 RID: 27346
		private static readonly System.IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x04006AD3 RID: 27347
		private static readonly System.IntPtr NativeMethodInfoPtr_OptionSelected_Private_Void_StationRecipe_0;

		// Token: 0x04006AD4 RID: 27348
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearClicked_Public_Void_0;

		// Token: 0x04006AD5 RID: 27349
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BE1 RID: 3041
		[ObfuscatedName("ScheduleOne.UI.Management.StationRecipeFieldUI+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E136 RID: 57654 RVA: 0x003569C0 File Offset: 0x00354BC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr);
				StationRecipeFieldUI.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr, "<>9");
				StationRecipeFieldUI.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr, "<>9__11_0");
				StationRecipeFieldUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr, 100682918);
				StationRecipeFieldUI.__c.NativeMethodInfoPtr__Clicked_b__11_0_Internal_Boolean_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr, 100682919);
			}

			// Token: 0x0600E137 RID: 57655 RVA: 0x00356A3C File Offset: 0x00354C3C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E138 RID: 57656 RVA: 0x00356A78 File Offset: 0x00354C78
			[CallerCount(0)]
			public unsafe bool _Clicked_b__11_0(StationRecipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.__c.NativeMethodInfoPtr__Clicked_b__11_0_Internal_Boolean_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E139 RID: 57657 RVA: 0x0006D64D File Offset: 0x0006B84D
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004582 RID: 17794
			// (get) Token: 0x0600E13A RID: 57658 RVA: 0x00356AC8 File Offset: 0x00354CC8
			// (set) Token: 0x0600E13B RID: 57659 RVA: 0x0006D656 File Offset: 0x0006B856
			public unsafe static StationRecipeFieldUI.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationRecipeFieldUI.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeFieldUI.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationRecipeFieldUI.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004583 RID: 17795
			// (get) Token: 0x0600E13C RID: 57660 RVA: 0x00356AF0 File Offset: 0x00354CF0
			// (set) Token: 0x0600E13D RID: 57661 RVA: 0x0006D668 File Offset: 0x0006B868
			public unsafe static Il2CppSystem.Func<StationRecipe, bool> __9__11_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationRecipeFieldUI.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<StationRecipe, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationRecipeFieldUI.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400970E RID: 38670
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400970F RID: 38671
			private static readonly System.IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04009710 RID: 38672
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009711 RID: 38673
			private static readonly System.IntPtr NativeMethodInfoPtr__Clicked_b__11_0_Internal_Boolean_StationRecipe_0;
		}
	}
}
