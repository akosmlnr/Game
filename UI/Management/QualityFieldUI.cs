using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006F0 RID: 1776
	public class QualityFieldUI : MonoBehaviour
	{
		// Token: 0x06009EAE RID: 40622 RVA: 0x0028572C File Offset: 0x0028392C
		// Note: this type is marked as 'beforefieldinit'.
		static QualityFieldUI()
		{
			Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "QualityFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr);
			QualityFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			QualityFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, "FieldLabel");
			QualityFieldUI.NativeFieldInfoPtr_QualityButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, "QualityButtons");
			QualityFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_QualityField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100682876);
			QualityFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_QualityField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100682877);
			QualityFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_QualityField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100682878);
			QualityFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100682879);
			QualityFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100682880);
			QualityFieldUI.NativeMethodInfoPtr_ValueChanged_Public_Void_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100682881);
			QualityFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100682882);
		}

		// Token: 0x170030AD RID: 12461
		// (get) Token: 0x06009EAF RID: 40623 RVA: 0x00285824 File Offset: 0x00283A24
		// (set) Token: 0x06009EB0 RID: 40624 RVA: 0x00285864 File Offset: 0x00283A64
		public unsafe List<QualityField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_QualityField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<QualityField>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_QualityField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009EB1 RID: 40625 RVA: 0x002858A8 File Offset: 0x00283AA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281594, RefRangeEnd = 281595, XrefRangeStart = 281553, XrefRangeEnd = 281594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<QualityField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_QualityField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EB2 RID: 40626 RVA: 0x002858EC File Offset: 0x00283AEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281609, RefRangeEnd = 281610, XrefRangeStart = 281595, XrefRangeEnd = 281609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(EQuality value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EB3 RID: 40627 RVA: 0x0028592C File Offset: 0x00283B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281610, XrefRangeEnd = 281617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009EB4 RID: 40628 RVA: 0x00285968 File Offset: 0x00283B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281617, XrefRangeEnd = 281623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValueChanged(EQuality value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr_ValueChanged_Public_Void_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EB5 RID: 40629 RVA: 0x002859A8 File Offset: 0x00283BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281623, XrefRangeEnd = 281631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EB6 RID: 40630 RVA: 0x0004D8E5 File Offset: 0x0004BAE5
		public QualityFieldUI(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030AA RID: 12458
		// (get) Token: 0x06009EB7 RID: 40631 RVA: 0x002859E4 File Offset: 0x00283BE4
		// (set) Token: 0x06009EB8 RID: 40632 RVA: 0x0004D8EE File Offset: 0x0004BAEE
		public unsafe List<QualityField> _Fields_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<QualityField>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030AB RID: 12459
		// (get) Token: 0x06009EB9 RID: 40633 RVA: 0x00285A14 File Offset: 0x00283C14
		// (set) Token: 0x06009EBA RID: 40634 RVA: 0x0004D90D File Offset: 0x0004BB0D
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.NativeFieldInfoPtr_FieldLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030AC RID: 12460
		// (get) Token: 0x06009EBB RID: 40635 RVA: 0x00285A44 File Offset: 0x00283C44
		// (set) Token: 0x06009EBC RID: 40636 RVA: 0x0004D92C File Offset: 0x0004BB2C
		public unsafe Il2CppReferenceArray<Button> QualityButtons
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.NativeFieldInfoPtr_QualityButtons);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.NativeFieldInfoPtr_QualityButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A9C RID: 27292
		private static readonly System.IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x04006A9D RID: 27293
		private static readonly System.IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x04006A9E RID: 27294
		private static readonly System.IntPtr NativeFieldInfoPtr_QualityButtons;

		// Token: 0x04006A9F RID: 27295
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_QualityField_0;

		// Token: 0x04006AA0 RID: 27296
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_QualityField_0;

		// Token: 0x04006AA1 RID: 27297
		private static readonly System.IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_QualityField_0;

		// Token: 0x04006AA2 RID: 27298
		private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Private_Void_EQuality_0;

		// Token: 0x04006AA3 RID: 27299
		private static readonly System.IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x04006AA4 RID: 27300
		private static readonly System.IntPtr NativeMethodInfoPtr_ValueChanged_Public_Void_EQuality_0;

		// Token: 0x04006AA5 RID: 27301
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BDF RID: 3039
		[ObfuscatedName("ScheduleOne.UI.Management.QualityFieldUI+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E126 RID: 57638 RVA: 0x00356730 File Offset: 0x00354930
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr);
				QualityFieldUI.__c__DisplayClass6_0.NativeFieldInfoPtr_quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr, "quality");
				QualityFieldUI.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				QualityFieldUI.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr, 100682883);
				QualityFieldUI.__c__DisplayClass6_0.NativeMethodInfoPtr__Bind_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr, 100682884);
			}

			// Token: 0x0600E127 RID: 57639 RVA: 0x003567AC File Offset: 0x003549AC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E128 RID: 57640 RVA: 0x003567E8 File Offset: 0x003549E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281547, XrefRangeEnd = 281553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Bind_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.__c__DisplayClass6_0.NativeMethodInfoPtr__Bind_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E129 RID: 57641 RVA: 0x0006D5C3 File Offset: 0x0006B7C3
			public __c__DisplayClass6_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700457E RID: 17790
			// (get) Token: 0x0600E12A RID: 57642 RVA: 0x0035681C File Offset: 0x00354A1C
			// (set) Token: 0x0600E12B RID: 57643 RVA: 0x0006D5CC File Offset: 0x0006B7CC
			public unsafe EQuality quality
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.__c__DisplayClass6_0.NativeFieldInfoPtr_quality);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.__c__DisplayClass6_0.NativeFieldInfoPtr_quality)) = value;
				}
			}

			// Token: 0x1700457F RID: 17791
			// (get) Token: 0x0600E12C RID: 57644 RVA: 0x00356844 File Offset: 0x00354A44
			// (set) Token: 0x0600E12D RID: 57645 RVA: 0x0006D5E7 File Offset: 0x0006B7E7
			public unsafe QualityFieldUI __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QualityFieldUI>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009706 RID: 38662
			private static readonly System.IntPtr NativeFieldInfoPtr_quality;

			// Token: 0x04009707 RID: 38663
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009708 RID: 38664
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009709 RID: 38665
			private static readonly System.IntPtr NativeMethodInfoPtr__Bind_b__0_Internal_Void_0;
		}
	}
}
