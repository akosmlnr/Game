using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000649 RID: 1609
	public class BalanceDisplay : MonoBehaviour
	{
		// Token: 0x06008CD2 RID: 36050 RVA: 0x00250978 File Offset: 0x0024EB78
		// Note: this type is marked as 'beforefieldinit'.
		static BalanceDisplay()
		{
			Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "BalanceDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr);
			BalanceDisplay.NativeFieldInfoPtr_RESIDUAL_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, "RESIDUAL_TIME");
			BalanceDisplay.NativeFieldInfoPtr_FADE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, "FADE_TIME");
			BalanceDisplay.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, "Group");
			BalanceDisplay.NativeFieldInfoPtr_BalanceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, "BalanceLabel");
			BalanceDisplay.NativeFieldInfoPtr__active_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, "<active>k__BackingField");
			BalanceDisplay.NativeFieldInfoPtr__timeSinceActiveSet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, "<timeSinceActiveSet>k__BackingField");
			BalanceDisplay.NativeMethodInfoPtr_get_active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100680892);
			BalanceDisplay.NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100680893);
			BalanceDisplay.NativeMethodInfoPtr_get_timeSinceActiveSet_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100680894);
			BalanceDisplay.NativeMethodInfoPtr_set_timeSinceActiveSet_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100680895);
			BalanceDisplay.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100680896);
			BalanceDisplay.NativeMethodInfoPtr_SetBalance_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100680897);
			BalanceDisplay.NativeMethodInfoPtr_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100680898);
			BalanceDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100680899);
		}

		// Token: 0x17002AB5 RID: 10933
		// (get) Token: 0x06008CD3 RID: 36051 RVA: 0x00250AC0 File Offset: 0x0024ECC0
		// (set) Token: 0x06008CD4 RID: 36052 RVA: 0x00250AFC File Offset: 0x0024ECFC
		public unsafe bool active
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BalanceDisplay.NativeMethodInfoPtr_get_active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BalanceDisplay.NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002AB6 RID: 10934
		// (get) Token: 0x06008CD5 RID: 36053 RVA: 0x00250B3C File Offset: 0x0024ED3C
		// (set) Token: 0x06008CD6 RID: 36054 RVA: 0x00250B78 File Offset: 0x0024ED78
		public unsafe float timeSinceActiveSet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BalanceDisplay.NativeMethodInfoPtr_get_timeSinceActiveSet_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BalanceDisplay.NativeMethodInfoPtr_set_timeSinceActiveSet_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008CD7 RID: 36055 RVA: 0x00250BB8 File Offset: 0x0024EDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258252, XrefRangeEnd = 258262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BalanceDisplay.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008CD8 RID: 36056 RVA: 0x00250BF4 File Offset: 0x0024EDF4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 258264, RefRangeEnd = 258270, XrefRangeStart = 258262, XrefRangeEnd = 258264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBalance(float balance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref balance;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BalanceDisplay.NativeMethodInfoPtr_SetBalance_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008CD9 RID: 36057 RVA: 0x00250C34 File Offset: 0x0024EE34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 258270, RefRangeEnd = 258274, XrefRangeStart = 258270, XrefRangeEnd = 258270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Show()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BalanceDisplay.NativeMethodInfoPtr_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008CDA RID: 36058 RVA: 0x00250C68 File Offset: 0x0024EE68
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BalanceDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BalanceDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008CDB RID: 36059 RVA: 0x00043152 File Offset: 0x00041352
		public BalanceDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AAF RID: 10927
		// (get) Token: 0x06008CDC RID: 36060 RVA: 0x00250CA4 File Offset: 0x0024EEA4
		// (set) Token: 0x06008CDD RID: 36061 RVA: 0x0004315B File Offset: 0x0004135B
		public unsafe static float RESIDUAL_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BalanceDisplay.NativeFieldInfoPtr_RESIDUAL_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BalanceDisplay.NativeFieldInfoPtr_RESIDUAL_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002AB0 RID: 10928
		// (get) Token: 0x06008CDE RID: 36062 RVA: 0x00250CC0 File Offset: 0x0024EEC0
		// (set) Token: 0x06008CDF RID: 36063 RVA: 0x00043169 File Offset: 0x00041369
		public unsafe static float FADE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BalanceDisplay.NativeFieldInfoPtr_FADE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BalanceDisplay.NativeFieldInfoPtr_FADE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002AB1 RID: 10929
		// (get) Token: 0x06008CE0 RID: 36064 RVA: 0x00250CDC File Offset: 0x0024EEDC
		// (set) Token: 0x06008CE1 RID: 36065 RVA: 0x00043177 File Offset: 0x00041377
		public unsafe CanvasGroup Group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr_Group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AB2 RID: 10930
		// (get) Token: 0x06008CE2 RID: 36066 RVA: 0x00250D0C File Offset: 0x0024EF0C
		// (set) Token: 0x06008CE3 RID: 36067 RVA: 0x00043196 File Offset: 0x00041396
		public unsafe TextMeshProUGUI BalanceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr_BalanceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr_BalanceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AB3 RID: 10931
		// (get) Token: 0x06008CE4 RID: 36068 RVA: 0x00250D3C File Offset: 0x0024EF3C
		// (set) Token: 0x06008CE5 RID: 36069 RVA: 0x000431B5 File Offset: 0x000413B5
		public unsafe bool _active_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr__active_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr__active_k__BackingField)) = value;
			}
		}

		// Token: 0x17002AB4 RID: 10932
		// (get) Token: 0x06008CE6 RID: 36070 RVA: 0x00250D64 File Offset: 0x0024EF64
		// (set) Token: 0x06008CE7 RID: 36071 RVA: 0x000431D0 File Offset: 0x000413D0
		public unsafe float _timeSinceActiveSet_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr__timeSinceActiveSet_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr__timeSinceActiveSet_k__BackingField)) = value;
			}
		}

		// Token: 0x04005F90 RID: 24464
		private static readonly IntPtr NativeFieldInfoPtr_RESIDUAL_TIME;

		// Token: 0x04005F91 RID: 24465
		private static readonly IntPtr NativeFieldInfoPtr_FADE_TIME;

		// Token: 0x04005F92 RID: 24466
		private static readonly IntPtr NativeFieldInfoPtr_Group;

		// Token: 0x04005F93 RID: 24467
		private static readonly IntPtr NativeFieldInfoPtr_BalanceLabel;

		// Token: 0x04005F94 RID: 24468
		private static readonly IntPtr NativeFieldInfoPtr__active_k__BackingField;

		// Token: 0x04005F95 RID: 24469
		private static readonly IntPtr NativeFieldInfoPtr__timeSinceActiveSet_k__BackingField;

		// Token: 0x04005F96 RID: 24470
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_get_Boolean_0;

		// Token: 0x04005F97 RID: 24471
		private static readonly IntPtr NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0;

		// Token: 0x04005F98 RID: 24472
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSinceActiveSet_Public_get_Single_0;

		// Token: 0x04005F99 RID: 24473
		private static readonly IntPtr NativeMethodInfoPtr_set_timeSinceActiveSet_Protected_set_Void_Single_0;

		// Token: 0x04005F9A RID: 24474
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04005F9B RID: 24475
		private static readonly IntPtr NativeMethodInfoPtr_SetBalance_Public_Void_Single_0;

		// Token: 0x04005F9C RID: 24476
		private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Void_0;

		// Token: 0x04005F9D RID: 24477
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
