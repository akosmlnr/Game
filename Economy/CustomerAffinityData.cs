using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000430 RID: 1072
	[System.Serializable]
	public class CustomerAffinityData : Il2CppSystem.Object
	{
		// Token: 0x06005BF5 RID: 23541 RVA: 0x001AD52C File Offset: 0x001AB72C
		// Note: this type is marked as 'beforefieldinit'.
		static CustomerAffinityData()
		{
			Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "CustomerAffinityData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr);
			CustomerAffinityData.NativeFieldInfoPtr_ProductAffinities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr, "ProductAffinities");
			CustomerAffinityData.NativeMethodInfoPtr_CopyTo_Public_Void_CustomerAffinityData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr, 100675090);
			CustomerAffinityData.NativeMethodInfoPtr_GetAffinity_Public_Single_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr, 100675091);
			CustomerAffinityData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr, 100675092);
		}

		// Token: 0x06005BF6 RID: 23542 RVA: 0x001AD5AC File Offset: 0x001AB7AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194750, RefRangeEnd = 194751, XrefRangeStart = 194706, XrefRangeEnd = 194750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(CustomerAffinityData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.NativeMethodInfoPtr_CopyTo_Public_Void_CustomerAffinityData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005BF7 RID: 23543 RVA: 0x001AD5F0 File Offset: 0x001AB7F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194767, RefRangeEnd = 194768, XrefRangeStart = 194751, XrefRangeEnd = 194767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAffinity(EDrugType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref type;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.NativeMethodInfoPtr_GetAffinity_Public_Single_EDrugType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005BF8 RID: 23544 RVA: 0x001AD63C File Offset: 0x001AB83C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194776, RefRangeEnd = 194777, XrefRangeStart = 194768, XrefRangeEnd = 194776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerAffinityData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005BF9 RID: 23545 RVA: 0x0002B39F File Offset: 0x0002959F
		public CustomerAffinityData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B88 RID: 7048
		// (get) Token: 0x06005BFA RID: 23546 RVA: 0x001AD678 File Offset: 0x001AB878
		// (set) Token: 0x06005BFB RID: 23547 RVA: 0x0002B3A8 File Offset: 0x000295A8
		public unsafe List<ProductTypeAffinity> ProductAffinities
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAffinityData.NativeFieldInfoPtr_ProductAffinities);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductTypeAffinity>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAffinityData.NativeFieldInfoPtr_ProductAffinities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003ECA RID: 16074
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductAffinities;

		// Token: 0x04003ECB RID: 16075
		private static readonly System.IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_CustomerAffinityData_0;

		// Token: 0x04003ECC RID: 16076
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAffinity_Public_Single_EDrugType_0;

		// Token: 0x04003ECD RID: 16077
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A2D RID: 2605
		[ObfuscatedName("ScheduleOne.Economy.CustomerAffinityData+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D258 RID: 53848 RVA: 0x0032CBDC File Offset: 0x0032ADDC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr);
				CustomerAffinityData.__c__DisplayClass1_0.NativeFieldInfoPtr_affinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr, "affinity");
				CustomerAffinityData.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr, 100675093);
				CustomerAffinityData.__c__DisplayClass1_0.NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_ProductTypeAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr, 100675094);
				CustomerAffinityData.__c__DisplayClass1_0.NativeMethodInfoPtr__CopyTo_b__1_Internal_Boolean_ProductTypeAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr, 100675095);
			}

			// Token: 0x0600D259 RID: 53849 RVA: 0x0032CC58 File Offset: 0x0032AE58
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D25A RID: 53850 RVA: 0x0032CC94 File Offset: 0x0032AE94
			[CallerCount(0)]
			public unsafe bool _CopyTo_b__0(ProductTypeAffinity x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.__c__DisplayClass1_0.NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_ProductTypeAffinity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D25B RID: 53851 RVA: 0x0032CCE4 File Offset: 0x0032AEE4
			[CallerCount(0)]
			public unsafe bool _CopyTo_b__1(ProductTypeAffinity x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.__c__DisplayClass1_0.NativeMethodInfoPtr__CopyTo_b__1_Internal_Boolean_ProductTypeAffinity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D25C RID: 53852 RVA: 0x00066002 File Offset: 0x00064202
			public __c__DisplayClass1_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700412D RID: 16685
			// (get) Token: 0x0600D25D RID: 53853 RVA: 0x0032CD34 File Offset: 0x0032AF34
			// (set) Token: 0x0600D25E RID: 53854 RVA: 0x0006600B File Offset: 0x0006420B
			public unsafe ProductTypeAffinity affinity
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAffinityData.__c__DisplayClass1_0.NativeFieldInfoPtr_affinity);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductTypeAffinity>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAffinityData.__c__DisplayClass1_0.NativeFieldInfoPtr_affinity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E2C RID: 36396
			private static readonly System.IntPtr NativeFieldInfoPtr_affinity;

			// Token: 0x04008E2D RID: 36397
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E2E RID: 36398
			private static readonly System.IntPtr NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_ProductTypeAffinity_0;

			// Token: 0x04008E2F RID: 36399
			private static readonly System.IntPtr NativeMethodInfoPtr__CopyTo_b__1_Internal_Boolean_ProductTypeAffinity_0;
		}

		// Token: 0x02000A2E RID: 2606
		[ObfuscatedName("ScheduleOne.Economy.CustomerAffinityData+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D25F RID: 53855 RVA: 0x0032CD64 File Offset: 0x0032AF64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass2_0>.NativeClassPtr);
				CustomerAffinityData.__c__DisplayClass2_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass2_0>.NativeClassPtr, "type");
				CustomerAffinityData.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass2_0>.NativeClassPtr, 100675096);
				CustomerAffinityData.__c__DisplayClass2_0.NativeMethodInfoPtr__GetAffinity_b__0_Internal_Boolean_ProductTypeAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass2_0>.NativeClassPtr, 100675097);
			}

			// Token: 0x0600D260 RID: 53856 RVA: 0x0032CDCC File Offset: 0x0032AFCC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass2_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D261 RID: 53857 RVA: 0x0032CE08 File Offset: 0x0032B008
			[CallerCount(0)]
			public unsafe bool _GetAffinity_b__0(ProductTypeAffinity x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.__c__DisplayClass2_0.NativeMethodInfoPtr__GetAffinity_b__0_Internal_Boolean_ProductTypeAffinity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D262 RID: 53858 RVA: 0x0006602A File Offset: 0x0006422A
			public __c__DisplayClass2_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700412E RID: 16686
			// (get) Token: 0x0600D263 RID: 53859 RVA: 0x0032CE58 File Offset: 0x0032B058
			// (set) Token: 0x0600D264 RID: 53860 RVA: 0x00066033 File Offset: 0x00064233
			public unsafe EDrugType type
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAffinityData.__c__DisplayClass2_0.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAffinityData.__c__DisplayClass2_0.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x04008E30 RID: 36400
			private static readonly System.IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04008E31 RID: 36401
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E32 RID: 36402
			private static readonly System.IntPtr NativeMethodInfoPtr__GetAffinity_b__0_Internal_Boolean_ProductTypeAffinity_0;
		}
	}
}
