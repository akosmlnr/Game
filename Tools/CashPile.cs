using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000551 RID: 1361
	public class CashPile : MonoBehaviour
	{
		// Token: 0x06007866 RID: 30822 RVA: 0x0020DA60 File Offset: 0x0020BC60
		// Note: this type is marked as 'beforefieldinit'.
		static CashPile()
		{
			Il2CppClassPointerStore<CashPile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "CashPile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashPile>.NativeClassPtr);
			CashPile.NativeFieldInfoPtr_MAX_AMOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashPile>.NativeClassPtr, "MAX_AMOUNT");
			CashPile.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashPile>.NativeClassPtr, "Container");
			CashPile.NativeFieldInfoPtr_CashInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashPile>.NativeClassPtr, "CashInstances");
			CashPile.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPile>.NativeClassPtr, 100678552);
			CashPile.NativeMethodInfoPtr_SetDisplayedAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPile>.NativeClassPtr, 100678553);
			CashPile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPile>.NativeClassPtr, 100678554);
		}

		// Token: 0x06007867 RID: 30823 RVA: 0x0020DB08 File Offset: 0x0020BD08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234497, XrefRangeEnd = 234508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashPile.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007868 RID: 30824 RVA: 0x0020DB3C File Offset: 0x0020BD3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 234515, RefRangeEnd = 234516, XrefRangeStart = 234508, XrefRangeEnd = 234515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDisplayedAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashPile.NativeMethodInfoPtr_SetDisplayedAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007869 RID: 30825 RVA: 0x0020DB7C File Offset: 0x0020BD7C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashPile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashPile>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashPile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600786A RID: 30826 RVA: 0x00038CFF File Offset: 0x00036EFF
		public CashPile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002441 RID: 9281
		// (get) Token: 0x0600786B RID: 30827 RVA: 0x0020DBB8 File Offset: 0x0020BDB8
		// (set) Token: 0x0600786C RID: 30828 RVA: 0x00038D08 File Offset: 0x00036F08
		public unsafe static float MAX_AMOUNT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CashPile.NativeFieldInfoPtr_MAX_AMOUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CashPile.NativeFieldInfoPtr_MAX_AMOUNT, (void*)(&value));
			}
		}

		// Token: 0x17002442 RID: 9282
		// (get) Token: 0x0600786D RID: 30829 RVA: 0x0020DBD4 File Offset: 0x0020BDD4
		// (set) Token: 0x0600786E RID: 30830 RVA: 0x00038D16 File Offset: 0x00036F16
		public unsafe Transform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPile.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPile.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002443 RID: 9283
		// (get) Token: 0x0600786F RID: 30831 RVA: 0x0020DC04 File Offset: 0x0020BE04
		// (set) Token: 0x06007870 RID: 30832 RVA: 0x00038D35 File Offset: 0x00036F35
		public unsafe Il2CppReferenceArray<Transform> CashInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPile.NativeFieldInfoPtr_CashInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPile.NativeFieldInfoPtr_CashInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005242 RID: 21058
		private static readonly IntPtr NativeFieldInfoPtr_MAX_AMOUNT;

		// Token: 0x04005243 RID: 21059
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005244 RID: 21060
		private static readonly IntPtr NativeFieldInfoPtr_CashInstances;

		// Token: 0x04005245 RID: 21061
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005246 RID: 21062
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedAmount_Public_Void_Single_0;

		// Token: 0x04005247 RID: 21063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
