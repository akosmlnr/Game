using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Management;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006EB RID: 1771
	public class ItemFieldUI : MonoBehaviour
	{
		// Token: 0x06009E28 RID: 40488 RVA: 0x00283D30 File Offset: 0x00281F30
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFieldUI()
		{
			Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ItemFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr);
			ItemFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			ItemFieldUI.NativeFieldInfoPtr_ShowNoneAsAny = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "ShowNoneAsAny");
			ItemFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "FieldLabel");
			ItemFieldUI.NativeFieldInfoPtr_IconImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "IconImg");
			ItemFieldUI.NativeFieldInfoPtr_SelectionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "SelectionLabel");
			ItemFieldUI.NativeFieldInfoPtr_NoneSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "NoneSelected");
			ItemFieldUI.NativeFieldInfoPtr_MultipleSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "MultipleSelected");
			ItemFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_ItemField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100682826);
			ItemFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ItemField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100682827);
			ItemFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_ItemField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100682828);
			ItemFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100682829);
			ItemFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100682830);
			ItemFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100682831);
			ItemFieldUI.NativeMethodInfoPtr_OptionSelected_Private_Void_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100682832);
			ItemFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100682833);
		}

		// Token: 0x17003084 RID: 12420
		// (get) Token: 0x06009E29 RID: 40489 RVA: 0x00283E8C File Offset: 0x0028208C
		// (set) Token: 0x06009E2A RID: 40490 RVA: 0x00283ECC File Offset: 0x002820CC
		public unsafe List<ItemField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_ItemField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemField>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ItemField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009E2B RID: 40491 RVA: 0x00283F10 File Offset: 0x00282110
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 280755, RefRangeEnd = 280759, XrefRangeStart = 280728, XrefRangeEnd = 280755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<ItemField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_ItemField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E2C RID: 40492 RVA: 0x00283F54 File Offset: 0x00282154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280782, RefRangeEnd = 280783, XrefRangeStart = 280759, XrefRangeEnd = 280782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(ItemDefinition newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVal);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E2D RID: 40493 RVA: 0x00283F98 File Offset: 0x00282198
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280794, RefRangeEnd = 280796, XrefRangeStart = 280783, XrefRangeEnd = 280794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009E2E RID: 40494 RVA: 0x00283FD4 File Offset: 0x002821D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280796, XrefRangeEnd = 280872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E2F RID: 40495 RVA: 0x00284008 File Offset: 0x00282208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280872, XrefRangeEnd = 280887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionSelected(ItemSelector.Option option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_OptionSelected_Private_Void_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E30 RID: 40496 RVA: 0x0028404C File Offset: 0x0028224C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280887, XrefRangeEnd = 280895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E31 RID: 40497 RVA: 0x0004D3E4 File Offset: 0x0004B5E4
		public ItemFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700307D RID: 12413
		// (get) Token: 0x06009E32 RID: 40498 RVA: 0x00284088 File Offset: 0x00282288
		// (set) Token: 0x06009E33 RID: 40499 RVA: 0x0004D3ED File Offset: 0x0004B5ED
		public unsafe List<ItemField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700307E RID: 12414
		// (get) Token: 0x06009E34 RID: 40500 RVA: 0x002840B8 File Offset: 0x002822B8
		// (set) Token: 0x06009E35 RID: 40501 RVA: 0x0004D40C File Offset: 0x0004B60C
		public unsafe bool ShowNoneAsAny
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_ShowNoneAsAny);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_ShowNoneAsAny)) = value;
			}
		}

		// Token: 0x1700307F RID: 12415
		// (get) Token: 0x06009E36 RID: 40502 RVA: 0x002840E0 File Offset: 0x002822E0
		// (set) Token: 0x06009E37 RID: 40503 RVA: 0x0004D427 File Offset: 0x0004B627
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_FieldLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003080 RID: 12416
		// (get) Token: 0x06009E38 RID: 40504 RVA: 0x00284110 File Offset: 0x00282310
		// (set) Token: 0x06009E39 RID: 40505 RVA: 0x0004D446 File Offset: 0x0004B646
		public unsafe Image IconImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_IconImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_IconImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003081 RID: 12417
		// (get) Token: 0x06009E3A RID: 40506 RVA: 0x00284140 File Offset: 0x00282340
		// (set) Token: 0x06009E3B RID: 40507 RVA: 0x0004D465 File Offset: 0x0004B665
		public unsafe TextMeshProUGUI SelectionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_SelectionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_SelectionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003082 RID: 12418
		// (get) Token: 0x06009E3C RID: 40508 RVA: 0x00284170 File Offset: 0x00282370
		// (set) Token: 0x06009E3D RID: 40509 RVA: 0x0004D484 File Offset: 0x0004B684
		public unsafe GameObject NoneSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_NoneSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_NoneSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003083 RID: 12419
		// (get) Token: 0x06009E3E RID: 40510 RVA: 0x002841A0 File Offset: 0x002823A0
		// (set) Token: 0x06009E3F RID: 40511 RVA: 0x0004D4A3 File Offset: 0x0004B6A3
		public unsafe GameObject MultipleSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_MultipleSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_MultipleSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A48 RID: 27208
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x04006A49 RID: 27209
		private static readonly IntPtr NativeFieldInfoPtr_ShowNoneAsAny;

		// Token: 0x04006A4A RID: 27210
		private static readonly IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x04006A4B RID: 27211
		private static readonly IntPtr NativeFieldInfoPtr_IconImg;

		// Token: 0x04006A4C RID: 27212
		private static readonly IntPtr NativeFieldInfoPtr_SelectionLabel;

		// Token: 0x04006A4D RID: 27213
		private static readonly IntPtr NativeFieldInfoPtr_NoneSelected;

		// Token: 0x04006A4E RID: 27214
		private static readonly IntPtr NativeFieldInfoPtr_MultipleSelected;

		// Token: 0x04006A4F RID: 27215
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_ItemField_0;

		// Token: 0x04006A50 RID: 27216
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ItemField_0;

		// Token: 0x04006A51 RID: 27217
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_ItemField_0;

		// Token: 0x04006A52 RID: 27218
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_ItemDefinition_0;

		// Token: 0x04006A53 RID: 27219
		private static readonly IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x04006A54 RID: 27220
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x04006A55 RID: 27221
		private static readonly IntPtr NativeMethodInfoPtr_OptionSelected_Private_Void_Option_0;

		// Token: 0x04006A56 RID: 27222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
