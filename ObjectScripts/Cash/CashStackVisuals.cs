using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts.Cash
{
	// Token: 0x02000790 RID: 1936
	public class CashStackVisuals : MonoBehaviour
	{
		// Token: 0x0600B7BB RID: 47035 RVA: 0x002DF4D8 File Offset: 0x002DD6D8
		// Note: this type is marked as 'beforefieldinit'.
		static CashStackVisuals()
		{
			Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.Cash", "CashStackVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr);
			CashStackVisuals.NativeFieldInfoPtr_MAX_AMOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, "MAX_AMOUNT");
			CashStackVisuals.NativeFieldInfoPtr_Visuals_Under100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, "Visuals_Under100");
			CashStackVisuals.NativeFieldInfoPtr_Notes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, "Notes");
			CashStackVisuals.NativeFieldInfoPtr_Visuals_Over100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, "Visuals_Over100");
			CashStackVisuals.NativeFieldInfoPtr_Bills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, "Bills");
			CashStackVisuals.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, 100686097);
			CashStackVisuals.NativeMethodInfoPtr_ShowAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, 100686098);
			CashStackVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, 100686099);
		}

		// Token: 0x0600B7BC RID: 47036 RVA: 0x002DF5A8 File Offset: 0x002DD7A8
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashStackVisuals.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7BD RID: 47037 RVA: 0x002DF5DC File Offset: 0x002DD7DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 314977, RefRangeEnd = 314980, XrefRangeStart = 314968, XrefRangeEnd = 314977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashStackVisuals.NativeMethodInfoPtr_ShowAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7BE RID: 47038 RVA: 0x002DF61C File Offset: 0x002DD81C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashStackVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashStackVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7BF RID: 47039 RVA: 0x00059ABD File Offset: 0x00057CBD
		public CashStackVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038AB RID: 14507
		// (get) Token: 0x0600B7C0 RID: 47040 RVA: 0x002DF658 File Offset: 0x002DD858
		// (set) Token: 0x0600B7C1 RID: 47041 RVA: 0x00059AC6 File Offset: 0x00057CC6
		public unsafe static float MAX_AMOUNT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CashStackVisuals.NativeFieldInfoPtr_MAX_AMOUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CashStackVisuals.NativeFieldInfoPtr_MAX_AMOUNT, (void*)(&value));
			}
		}

		// Token: 0x170038AC RID: 14508
		// (get) Token: 0x0600B7C2 RID: 47042 RVA: 0x002DF674 File Offset: 0x002DD874
		// (set) Token: 0x0600B7C3 RID: 47043 RVA: 0x00059AD4 File Offset: 0x00057CD4
		public unsafe GameObject Visuals_Under100
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Visuals_Under100);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Visuals_Under100), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038AD RID: 14509
		// (get) Token: 0x0600B7C4 RID: 47044 RVA: 0x002DF6A4 File Offset: 0x002DD8A4
		// (set) Token: 0x0600B7C5 RID: 47045 RVA: 0x00059AF3 File Offset: 0x00057CF3
		public unsafe Il2CppReferenceArray<GameObject> Notes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Notes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Notes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038AE RID: 14510
		// (get) Token: 0x0600B7C6 RID: 47046 RVA: 0x002DF6D4 File Offset: 0x002DD8D4
		// (set) Token: 0x0600B7C7 RID: 47047 RVA: 0x00059B12 File Offset: 0x00057D12
		public unsafe GameObject Visuals_Over100
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Visuals_Over100);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Visuals_Over100), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038AF RID: 14511
		// (get) Token: 0x0600B7C8 RID: 47048 RVA: 0x002DF704 File Offset: 0x002DD904
		// (set) Token: 0x0600B7C9 RID: 47049 RVA: 0x00059B31 File Offset: 0x00057D31
		public unsafe Il2CppReferenceArray<GameObject> Bills
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Bills);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Bills), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007C0D RID: 31757
		private static readonly IntPtr NativeFieldInfoPtr_MAX_AMOUNT;

		// Token: 0x04007C0E RID: 31758
		private static readonly IntPtr NativeFieldInfoPtr_Visuals_Under100;

		// Token: 0x04007C0F RID: 31759
		private static readonly IntPtr NativeFieldInfoPtr_Notes;

		// Token: 0x04007C10 RID: 31760
		private static readonly IntPtr NativeFieldInfoPtr_Visuals_Over100;

		// Token: 0x04007C11 RID: 31761
		private static readonly IntPtr NativeFieldInfoPtr_Bills;

		// Token: 0x04007C12 RID: 31762
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007C13 RID: 31763
		private static readonly IntPtr NativeMethodInfoPtr_ShowAmount_Public_Void_Single_0;

		// Token: 0x04007C14 RID: 31764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
