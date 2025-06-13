using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts.Cash
{
	// Token: 0x0200078F RID: 1935
	public class Cash : MonoBehaviour
	{
		// Token: 0x0600B7B3 RID: 47027 RVA: 0x002DF398 File Offset: 0x002DD598
		// Note: this type is marked as 'beforefieldinit'.
		static Cash()
		{
			Il2CppClassPointerStore<Cash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.Cash", "Cash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cash>.NativeClassPtr);
			Cash.NativeFieldInfoPtr_stackSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cash>.NativeClassPtr, "stackSize");
			Cash.NativeFieldInfoPtr_amounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cash>.NativeClassPtr, "amounts");
			Cash.NativeMethodInfoPtr_GetBillStacksToDisplay_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cash>.NativeClassPtr, 100686094);
			Cash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cash>.NativeClassPtr, 100686095);
		}

		// Token: 0x0600B7B4 RID: 47028 RVA: 0x002DF418 File Offset: 0x002DD618
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314967, RefRangeEnd = 314968, XrefRangeStart = 314967, XrefRangeEnd = 314967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetBillStacksToDisplay(float amount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Cash.NativeMethodInfoPtr_GetBillStacksToDisplay_Public_Static_Int32_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B7B5 RID: 47029 RVA: 0x002DF458 File Offset: 0x002DD658
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cash>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7B6 RID: 47030 RVA: 0x00059A94 File Offset: 0x00057C94
		public Cash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038A9 RID: 14505
		// (get) Token: 0x0600B7B7 RID: 47031 RVA: 0x002DF494 File Offset: 0x002DD694
		// (set) Token: 0x0600B7B8 RID: 47032 RVA: 0x00059A9D File Offset: 0x00057C9D
		public unsafe static float stackSize
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Cash.NativeFieldInfoPtr_stackSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Cash.NativeFieldInfoPtr_stackSize, (void*)(&value));
			}
		}

		// Token: 0x170038AA RID: 14506
		// (get) Token: 0x0600B7B9 RID: 47033 RVA: 0x002DF4B0 File Offset: 0x002DD6B0
		// (set) Token: 0x0600B7BA RID: 47034 RVA: 0x00059AAB File Offset: 0x00057CAB
		public unsafe static Il2CppStructArray<int> amounts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Cash.NativeFieldInfoPtr_amounts, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Cash.NativeFieldInfoPtr_amounts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007C09 RID: 31753
		private static readonly IntPtr NativeFieldInfoPtr_stackSize;

		// Token: 0x04007C0A RID: 31754
		private static readonly IntPtr NativeFieldInfoPtr_amounts;

		// Token: 0x04007C0B RID: 31755
		private static readonly IntPtr NativeMethodInfoPtr_GetBillStacksToDisplay_Public_Static_Int32_Single_0;

		// Token: 0x04007C0C RID: 31756
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
