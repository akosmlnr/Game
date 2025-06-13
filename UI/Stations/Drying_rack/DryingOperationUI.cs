using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.UI.Tooltips;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations.Drying_rack
{
	// Token: 0x020006A7 RID: 1703
	public class DryingOperationUI : MonoBehaviour
	{
		// Token: 0x060097BE RID: 38846 RVA: 0x00270E20 File Offset: 0x0026F020
		// Note: this type is marked as 'beforefieldinit'.
		static DryingOperationUI()
		{
			Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations.Drying_rack", "DryingOperationUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr);
			DryingOperationUI.NativeFieldInfoPtr__AssignedOperation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "<AssignedOperation>k__BackingField");
			DryingOperationUI.NativeFieldInfoPtr__Alignment_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "<Alignment>k__BackingField");
			DryingOperationUI.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "Rect");
			DryingOperationUI.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "Icon");
			DryingOperationUI.NativeFieldInfoPtr_QuantityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "QuantityLabel");
			DryingOperationUI.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "Button");
			DryingOperationUI.NativeFieldInfoPtr_Tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "Tooltip");
			DryingOperationUI.NativeMethodInfoPtr_get_AssignedOperation_Public_get_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100682148);
			DryingOperationUI.NativeMethodInfoPtr_set_AssignedOperation_Protected_set_Void_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100682149);
			DryingOperationUI.NativeMethodInfoPtr_get_Alignment_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100682150);
			DryingOperationUI.NativeMethodInfoPtr_set_Alignment_Private_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100682151);
			DryingOperationUI.NativeMethodInfoPtr_SetOperation_Public_Void_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100682152);
			DryingOperationUI.NativeMethodInfoPtr_SetAlignment_Public_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100682153);
			DryingOperationUI.NativeMethodInfoPtr_RefreshQuantity_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100682154);
			DryingOperationUI.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100682155);
			DryingOperationUI.NativeMethodInfoPtr_UpdatePosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100682156);
			DryingOperationUI.NativeMethodInfoPtr_Clicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100682157);
			DryingOperationUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100682158);
			DryingOperationUI.NativeMethodInfoPtr__Start_b__16_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100682159);
		}

		// Token: 0x17002E70 RID: 11888
		// (get) Token: 0x060097BF RID: 38847 RVA: 0x00270FCC File Offset: 0x0026F1CC
		// (set) Token: 0x060097C0 RID: 38848 RVA: 0x0027100C File Offset: 0x0026F20C
		public unsafe DryingOperation AssignedOperation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_get_AssignedOperation_Public_get_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingOperation>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_set_AssignedOperation_Protected_set_Void_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002E71 RID: 11889
		// (get) Token: 0x060097C1 RID: 38849 RVA: 0x00271050 File Offset: 0x0026F250
		// (set) Token: 0x060097C2 RID: 38850 RVA: 0x00271090 File Offset: 0x0026F290
		public unsafe RectTransform Alignment
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_get_Alignment_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20985, RefRangeEnd = 20988, XrefRangeStart = 20985, XrefRangeEnd = 20988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_set_Alignment_Private_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060097C3 RID: 38851 RVA: 0x002710D4 File Offset: 0x0026F2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272576, XrefRangeEnd = 272582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOperation(DryingOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_SetOperation_Public_Void_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060097C4 RID: 38852 RVA: 0x00271118 File Offset: 0x0026F318
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 272587, RefRangeEnd = 272588, XrefRangeStart = 272582, XrefRangeEnd = 272587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAlignment(RectTransform alignment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(alignment);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_SetAlignment_Public_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060097C5 RID: 38853 RVA: 0x0027115C File Offset: 0x0026F35C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 272593, RefRangeEnd = 272596, XrefRangeStart = 272588, XrefRangeEnd = 272593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshQuantity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_RefreshQuantity_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060097C6 RID: 38854 RVA: 0x00271190 File Offset: 0x0026F390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272596, XrefRangeEnd = 272604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060097C7 RID: 38855 RVA: 0x002711C4 File Offset: 0x0026F3C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 272616, RefRangeEnd = 272620, XrefRangeStart = 272604, XrefRangeEnd = 272616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_UpdatePosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060097C8 RID: 38856 RVA: 0x002711F8 File Offset: 0x0026F3F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 272633, RefRangeEnd = 272634, XrefRangeStart = 272620, XrefRangeEnd = 272633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_Clicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060097C9 RID: 38857 RVA: 0x0027122C File Offset: 0x0026F42C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingOperationUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060097CA RID: 38858 RVA: 0x00271268 File Offset: 0x0026F468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272634, XrefRangeEnd = 272635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__16_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr__Start_b__16_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060097CB RID: 38859 RVA: 0x00049855 File Offset: 0x00047A55
		public DryingOperationUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E69 RID: 11881
		// (get) Token: 0x060097CC RID: 38860 RVA: 0x0027129C File Offset: 0x0026F49C
		// (set) Token: 0x060097CD RID: 38861 RVA: 0x0004985E File Offset: 0x00047A5E
		public unsafe DryingOperation _AssignedOperation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr__AssignedOperation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr__AssignedOperation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E6A RID: 11882
		// (get) Token: 0x060097CE RID: 38862 RVA: 0x002712CC File Offset: 0x0026F4CC
		// (set) Token: 0x060097CF RID: 38863 RVA: 0x0004987D File Offset: 0x00047A7D
		public unsafe RectTransform _Alignment_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr__Alignment_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr__Alignment_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E6B RID: 11883
		// (get) Token: 0x060097D0 RID: 38864 RVA: 0x002712FC File Offset: 0x0026F4FC
		// (set) Token: 0x060097D1 RID: 38865 RVA: 0x0004989C File Offset: 0x00047A9C
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E6C RID: 11884
		// (get) Token: 0x060097D2 RID: 38866 RVA: 0x0027132C File Offset: 0x0026F52C
		// (set) Token: 0x060097D3 RID: 38867 RVA: 0x000498BB File Offset: 0x00047ABB
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E6D RID: 11885
		// (get) Token: 0x060097D4 RID: 38868 RVA: 0x0027135C File Offset: 0x0026F55C
		// (set) Token: 0x060097D5 RID: 38869 RVA: 0x000498DA File Offset: 0x00047ADA
		public unsafe TextMeshProUGUI QuantityLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_QuantityLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_QuantityLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E6E RID: 11886
		// (get) Token: 0x060097D6 RID: 38870 RVA: 0x0027138C File Offset: 0x0026F58C
		// (set) Token: 0x060097D7 RID: 38871 RVA: 0x000498F9 File Offset: 0x00047AF9
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E6F RID: 11887
		// (get) Token: 0x060097D8 RID: 38872 RVA: 0x002713BC File Offset: 0x0026F5BC
		// (set) Token: 0x060097D9 RID: 38873 RVA: 0x00049918 File Offset: 0x00047B18
		public unsafe Tooltip Tooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Tooltip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tooltip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Tooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400665D RID: 26205
		private static readonly IntPtr NativeFieldInfoPtr__AssignedOperation_k__BackingField;

		// Token: 0x0400665E RID: 26206
		private static readonly IntPtr NativeFieldInfoPtr__Alignment_k__BackingField;

		// Token: 0x0400665F RID: 26207
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x04006660 RID: 26208
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x04006661 RID: 26209
		private static readonly IntPtr NativeFieldInfoPtr_QuantityLabel;

		// Token: 0x04006662 RID: 26210
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x04006663 RID: 26211
		private static readonly IntPtr NativeFieldInfoPtr_Tooltip;

		// Token: 0x04006664 RID: 26212
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedOperation_Public_get_DryingOperation_0;

		// Token: 0x04006665 RID: 26213
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedOperation_Protected_set_Void_DryingOperation_0;

		// Token: 0x04006666 RID: 26214
		private static readonly IntPtr NativeMethodInfoPtr_get_Alignment_Public_get_RectTransform_0;

		// Token: 0x04006667 RID: 26215
		private static readonly IntPtr NativeMethodInfoPtr_set_Alignment_Private_set_Void_RectTransform_0;

		// Token: 0x04006668 RID: 26216
		private static readonly IntPtr NativeMethodInfoPtr_SetOperation_Public_Void_DryingOperation_0;

		// Token: 0x04006669 RID: 26217
		private static readonly IntPtr NativeMethodInfoPtr_SetAlignment_Public_Void_RectTransform_0;

		// Token: 0x0400666A RID: 26218
		private static readonly IntPtr NativeMethodInfoPtr_RefreshQuantity_Public_Void_0;

		// Token: 0x0400666B RID: 26219
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400666C RID: 26220
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePosition_Public_Void_0;

		// Token: 0x0400666D RID: 26221
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Private_Void_0;

		// Token: 0x0400666E RID: 26222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400666F RID: 26223
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__16_0_Private_Void_0;
	}
}
