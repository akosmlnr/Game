using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006ED RID: 1773
	public class NumberFieldUI : MonoBehaviour
	{
		// Token: 0x06009E59 RID: 40537 RVA: 0x002846C0 File Offset: 0x002828C0
		// Note: this type is marked as 'beforefieldinit'.
		static NumberFieldUI()
		{
			Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "NumberFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr);
			NumberFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			NumberFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, "FieldLabel");
			NumberFieldUI.NativeFieldInfoPtr_Slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, "Slider");
			NumberFieldUI.NativeFieldInfoPtr_ValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, "ValueLabel");
			NumberFieldUI.NativeFieldInfoPtr_MinValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, "MinValueLabel");
			NumberFieldUI.NativeFieldInfoPtr_MaxValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, "MaxValueLabel");
			NumberFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_NumberField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100682846);
			NumberFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_NumberField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100682847);
			NumberFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_NumberField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100682848);
			NumberFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100682849);
			NumberFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100682850);
			NumberFieldUI.NativeMethodInfoPtr_ValueChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100682851);
			NumberFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100682852);
		}

		// Token: 0x17003093 RID: 12435
		// (get) Token: 0x06009E5A RID: 40538 RVA: 0x002847F4 File Offset: 0x002829F4
		// (set) Token: 0x06009E5B RID: 40539 RVA: 0x00284834 File Offset: 0x00282A34
		public unsafe List<NumberField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_NumberField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NumberField>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_NumberField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009E5C RID: 40540 RVA: 0x00284878 File Offset: 0x00282A78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281094, RefRangeEnd = 281095, XrefRangeStart = 281036, XrefRangeEnd = 281094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<NumberField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_NumberField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E5D RID: 40541 RVA: 0x002848BC File Offset: 0x00282ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281095, XrefRangeEnd = 281106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E5E RID: 40542 RVA: 0x002848FC File Offset: 0x00282AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281106, XrefRangeEnd = 281113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009E5F RID: 40543 RVA: 0x00284938 File Offset: 0x00282B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281113, XrefRangeEnd = 281119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr_ValueChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E60 RID: 40544 RVA: 0x00284978 File Offset: 0x00282B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281119, XrefRangeEnd = 281127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E61 RID: 40545 RVA: 0x0004D5A4 File Offset: 0x0004B7A4
		public NumberFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700308D RID: 12429
		// (get) Token: 0x06009E62 RID: 40546 RVA: 0x002849B4 File Offset: 0x00282BB4
		// (set) Token: 0x06009E63 RID: 40547 RVA: 0x0004D5AD File Offset: 0x0004B7AD
		public unsafe List<NumberField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NumberField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700308E RID: 12430
		// (get) Token: 0x06009E64 RID: 40548 RVA: 0x002849E4 File Offset: 0x00282BE4
		// (set) Token: 0x06009E65 RID: 40549 RVA: 0x0004D5CC File Offset: 0x0004B7CC
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_FieldLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700308F RID: 12431
		// (get) Token: 0x06009E66 RID: 40550 RVA: 0x00284A14 File Offset: 0x00282C14
		// (set) Token: 0x06009E67 RID: 40551 RVA: 0x0004D5EB File Offset: 0x0004B7EB
		public unsafe Slider Slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_Slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_Slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003090 RID: 12432
		// (get) Token: 0x06009E68 RID: 40552 RVA: 0x00284A44 File Offset: 0x00282C44
		// (set) Token: 0x06009E69 RID: 40553 RVA: 0x0004D60A File Offset: 0x0004B80A
		public unsafe TextMeshProUGUI ValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_ValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_ValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003091 RID: 12433
		// (get) Token: 0x06009E6A RID: 40554 RVA: 0x00284A74 File Offset: 0x00282C74
		// (set) Token: 0x06009E6B RID: 40555 RVA: 0x0004D629 File Offset: 0x0004B829
		public unsafe TextMeshProUGUI MinValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_MinValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_MinValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003092 RID: 12434
		// (get) Token: 0x06009E6C RID: 40556 RVA: 0x00284AA4 File Offset: 0x00282CA4
		// (set) Token: 0x06009E6D RID: 40557 RVA: 0x0004D648 File Offset: 0x0004B848
		public unsafe TextMeshProUGUI MaxValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_MaxValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_MaxValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A67 RID: 27239
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x04006A68 RID: 27240
		private static readonly IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x04006A69 RID: 27241
		private static readonly IntPtr NativeFieldInfoPtr_Slider;

		// Token: 0x04006A6A RID: 27242
		private static readonly IntPtr NativeFieldInfoPtr_ValueLabel;

		// Token: 0x04006A6B RID: 27243
		private static readonly IntPtr NativeFieldInfoPtr_MinValueLabel;

		// Token: 0x04006A6C RID: 27244
		private static readonly IntPtr NativeFieldInfoPtr_MaxValueLabel;

		// Token: 0x04006A6D RID: 27245
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_NumberField_0;

		// Token: 0x04006A6E RID: 27246
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_NumberField_0;

		// Token: 0x04006A6F RID: 27247
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_NumberField_0;

		// Token: 0x04006A70 RID: 27248
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_Single_0;

		// Token: 0x04006A71 RID: 27249
		private static readonly IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x04006A72 RID: 27250
		private static readonly IntPtr NativeMethodInfoPtr_ValueChanged_Public_Void_Single_0;

		// Token: 0x04006A73 RID: 27251
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
