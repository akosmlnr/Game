using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Construction.Features;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Construction
{
	// Token: 0x0200074A RID: 1866
	public class FeatureIcon : MonoBehaviour
	{
		// Token: 0x0600A757 RID: 42839 RVA: 0x002A0BC8 File Offset: 0x0029EDC8
		// Note: this type is marked as 'beforefieldinit'.
		static FeatureIcon()
		{
			Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Construction", "FeatureIcon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr);
			FeatureIcon.NativeFieldInfoPtr_selectedFeatureIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, "selectedFeatureIcon");
			FeatureIcon.NativeFieldInfoPtr_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, "rectTransform");
			FeatureIcon.NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, "icon");
			FeatureIcon.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, "text");
			FeatureIcon.NativeFieldInfoPtr_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, "background");
			FeatureIcon.NativeFieldInfoPtr__feature_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, "<feature>k__BackingField");
			FeatureIcon.NativeFieldInfoPtr__isSelected_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, "<isSelected>k__BackingField");
			FeatureIcon.NativeFieldInfoPtr_hovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, "hovered");
			FeatureIcon.NativeMethodInfoPtr_get_feature_Public_get_Feature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683855);
			FeatureIcon.NativeMethodInfoPtr_set_feature_Protected_set_Void_Feature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683856);
			FeatureIcon.NativeMethodInfoPtr_get_isSelected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683857);
			FeatureIcon.NativeMethodInfoPtr_set_isSelected_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683858);
			FeatureIcon.NativeMethodInfoPtr_AssignFeature_Public_Void_Feature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683859);
			FeatureIcon.NativeMethodInfoPtr_UpdateTransform_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683860);
			FeatureIcon.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683861);
			FeatureIcon.NativeMethodInfoPtr_SetIsSelected_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683862);
			FeatureIcon.NativeMethodInfoPtr_UpdateColors_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683863);
			FeatureIcon.NativeMethodInfoPtr_PointerEnter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683864);
			FeatureIcon.NativeMethodInfoPtr_PointerExit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683865);
			FeatureIcon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683866);
		}

		// Token: 0x17003375 RID: 13173
		// (get) Token: 0x0600A758 RID: 42840 RVA: 0x002A0D88 File Offset: 0x0029EF88
		// (set) Token: 0x0600A759 RID: 42841 RVA: 0x002A0DC8 File Offset: 0x0029EFC8
		public unsafe Feature feature
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37506, RefRangeEnd = 37507, XrefRangeStart = 37506, XrefRangeEnd = 37507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_get_feature_Public_get_Feature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Feature>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_set_feature_Protected_set_Void_Feature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003376 RID: 13174
		// (get) Token: 0x0600A75A RID: 42842 RVA: 0x002A0E0C File Offset: 0x0029F00C
		// (set) Token: 0x0600A75B RID: 42843 RVA: 0x002A0E48 File Offset: 0x0029F048
		public unsafe bool isSelected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_get_isSelected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 53388, RefRangeEnd = 53391, XrefRangeStart = 53388, XrefRangeEnd = 53391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_set_isSelected_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A75C RID: 42844 RVA: 0x002A0E88 File Offset: 0x0029F088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292558, XrefRangeEnd = 292563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignFeature(Feature _feature)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_feature);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_AssignFeature_Public_Void_Feature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A75D RID: 42845 RVA: 0x002A0ECC File Offset: 0x0029F0CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292592, RefRangeEnd = 292593, XrefRangeStart = 292563, XrefRangeEnd = 292592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_UpdateTransform_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A75E RID: 42846 RVA: 0x002A0F00 File Offset: 0x0029F100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292593, XrefRangeEnd = 292603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A75F RID: 42847 RVA: 0x002A0F34 File Offset: 0x0029F134
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 292626, RefRangeEnd = 292629, XrefRangeStart = 292603, XrefRangeEnd = 292626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsSelected(bool s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref s;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_SetIsSelected_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A760 RID: 42848 RVA: 0x002A0F74 File Offset: 0x0029F174
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292629, RefRangeEnd = 292630, XrefRangeStart = 292629, XrefRangeEnd = 292629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateColors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_UpdateColors_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A761 RID: 42849 RVA: 0x002A0FA8 File Offset: 0x0029F1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292630, XrefRangeEnd = 292633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PointerEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_PointerEnter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A762 RID: 42850 RVA: 0x002A0FDC File Offset: 0x0029F1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292633, XrefRangeEnd = 292635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PointerExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_PointerExit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A763 RID: 42851 RVA: 0x002A1010 File Offset: 0x0029F210
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FeatureIcon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A764 RID: 42852 RVA: 0x00052465 File Offset: 0x00050665
		public FeatureIcon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700336D RID: 13165
		// (get) Token: 0x0600A765 RID: 42853 RVA: 0x002A104C File Offset: 0x0029F24C
		// (set) Token: 0x0600A766 RID: 42854 RVA: 0x0005246E File Offset: 0x0005066E
		public unsafe static FeatureIcon selectedFeatureIcon
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FeatureIcon.NativeFieldInfoPtr_selectedFeatureIcon, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureIcon>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FeatureIcon.NativeFieldInfoPtr_selectedFeatureIcon, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700336E RID: 13166
		// (get) Token: 0x0600A767 RID: 42855 RVA: 0x002A1074 File Offset: 0x0029F274
		// (set) Token: 0x0600A768 RID: 42856 RVA: 0x00052480 File Offset: 0x00050680
		public unsafe RectTransform rectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_rectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700336F RID: 13167
		// (get) Token: 0x0600A769 RID: 42857 RVA: 0x002A10A4 File Offset: 0x0029F2A4
		// (set) Token: 0x0600A76A RID: 42858 RVA: 0x0005249F File Offset: 0x0005069F
		public unsafe Image icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003370 RID: 13168
		// (get) Token: 0x0600A76B RID: 42859 RVA: 0x002A10D4 File Offset: 0x0029F2D4
		// (set) Token: 0x0600A76C RID: 42860 RVA: 0x000524BE File Offset: 0x000506BE
		public unsafe TextMeshProUGUI text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003371 RID: 13169
		// (get) Token: 0x0600A76D RID: 42861 RVA: 0x002A1104 File Offset: 0x0029F304
		// (set) Token: 0x0600A76E RID: 42862 RVA: 0x000524DD File Offset: 0x000506DD
		public unsafe Image background
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_background);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_background), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003372 RID: 13170
		// (get) Token: 0x0600A76F RID: 42863 RVA: 0x002A1134 File Offset: 0x0029F334
		// (set) Token: 0x0600A770 RID: 42864 RVA: 0x000524FC File Offset: 0x000506FC
		public unsafe Feature _feature_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr__feature_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Feature>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr__feature_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003373 RID: 13171
		// (get) Token: 0x0600A771 RID: 42865 RVA: 0x002A1164 File Offset: 0x0029F364
		// (set) Token: 0x0600A772 RID: 42866 RVA: 0x0005251B File Offset: 0x0005071B
		public unsafe bool _isSelected_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr__isSelected_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr__isSelected_k__BackingField)) = value;
			}
		}

		// Token: 0x17003374 RID: 13172
		// (get) Token: 0x0600A773 RID: 42867 RVA: 0x002A118C File Offset: 0x0029F38C
		// (set) Token: 0x0600A774 RID: 42868 RVA: 0x00052536 File Offset: 0x00050736
		public unsafe bool hovered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_hovered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_hovered)) = value;
			}
		}

		// Token: 0x04007034 RID: 28724
		private static readonly IntPtr NativeFieldInfoPtr_selectedFeatureIcon;

		// Token: 0x04007035 RID: 28725
		private static readonly IntPtr NativeFieldInfoPtr_rectTransform;

		// Token: 0x04007036 RID: 28726
		private static readonly IntPtr NativeFieldInfoPtr_icon;

		// Token: 0x04007037 RID: 28727
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04007038 RID: 28728
		private static readonly IntPtr NativeFieldInfoPtr_background;

		// Token: 0x04007039 RID: 28729
		private static readonly IntPtr NativeFieldInfoPtr__feature_k__BackingField;

		// Token: 0x0400703A RID: 28730
		private static readonly IntPtr NativeFieldInfoPtr__isSelected_k__BackingField;

		// Token: 0x0400703B RID: 28731
		private static readonly IntPtr NativeFieldInfoPtr_hovered;

		// Token: 0x0400703C RID: 28732
		private static readonly IntPtr NativeMethodInfoPtr_get_feature_Public_get_Feature_0;

		// Token: 0x0400703D RID: 28733
		private static readonly IntPtr NativeMethodInfoPtr_set_feature_Protected_set_Void_Feature_0;

		// Token: 0x0400703E RID: 28734
		private static readonly IntPtr NativeMethodInfoPtr_get_isSelected_Public_get_Boolean_0;

		// Token: 0x0400703F RID: 28735
		private static readonly IntPtr NativeMethodInfoPtr_set_isSelected_Protected_set_Void_Boolean_0;

		// Token: 0x04007040 RID: 28736
		private static readonly IntPtr NativeMethodInfoPtr_AssignFeature_Public_Void_Feature_0;

		// Token: 0x04007041 RID: 28737
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransform_Public_Void_0;

		// Token: 0x04007042 RID: 28738
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x04007043 RID: 28739
		private static readonly IntPtr NativeMethodInfoPtr_SetIsSelected_Public_Void_Boolean_0;

		// Token: 0x04007044 RID: 28740
		private static readonly IntPtr NativeMethodInfoPtr_UpdateColors_Private_Void_0;

		// Token: 0x04007045 RID: 28741
		private static readonly IntPtr NativeMethodInfoPtr_PointerEnter_Public_Void_0;

		// Token: 0x04007046 RID: 28742
		private static readonly IntPtr NativeMethodInfoPtr_PointerExit_Public_Void_0;

		// Token: 0x04007047 RID: 28743
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
