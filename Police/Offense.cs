using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Police
{
	// Token: 0x02000208 RID: 520
	public class Offense : Il2CppSystem.Object
	{
		// Token: 0x06002998 RID: 10648 RVA: 0x000F7120 File Offset: 0x000F5320
		// Note: this type is marked as 'beforefieldinit'.
		static Offense()
		{
			Il2CppClassPointerStore<Offense>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Police", "Offense");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Offense>.NativeClassPtr);
			Offense.NativeFieldInfoPtr_charges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offense>.NativeClassPtr, "charges");
			Offense.NativeFieldInfoPtr_penalties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offense>.NativeClassPtr, "penalties");
			Offense.NativeMethodInfoPtr__ctor_Public_Void_List_1_Charge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offense>.NativeClassPtr, 100668037);
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x000F718C File Offset: 0x000F538C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122642, XrefRangeEnd = 122661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Offense(List<Offense.Charge> _charges) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Offense>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_charges);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Offense.NativeMethodInfoPtr__ctor_Public_Void_List_1_Charge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x00016721 File Offset: 0x00014921
		public Offense(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x0600299B RID: 10651 RVA: 0x000F71D8 File Offset: 0x000F53D8
		// (set) Token: 0x0600299C RID: 10652 RVA: 0x0001672A File Offset: 0x0001492A
		public unsafe List<Offense.Charge> charges
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.NativeFieldInfoPtr_charges);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Offense.Charge>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.NativeFieldInfoPtr_charges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x0600299D RID: 10653 RVA: 0x000F7208 File Offset: 0x000F5408
		// (set) Token: 0x0600299E RID: 10654 RVA: 0x00016749 File Offset: 0x00014949
		public unsafe List<string> penalties
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.NativeFieldInfoPtr_penalties);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.NativeFieldInfoPtr_penalties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B98 RID: 7064
		private static readonly System.IntPtr NativeFieldInfoPtr_charges;

		// Token: 0x04001B99 RID: 7065
		private static readonly System.IntPtr NativeFieldInfoPtr_penalties;

		// Token: 0x04001B9A RID: 7066
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_Charge_0;

		// Token: 0x0200090F RID: 2319
		public class Charge : Il2CppSystem.Object
		{
			// Token: 0x0600C8E2 RID: 51426 RVA: 0x003115D4 File Offset: 0x0030F7D4
			// Note: this type is marked as 'beforefieldinit'.
			static Charge()
			{
				Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Offense>.NativeClassPtr, "Charge");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr);
				Offense.Charge.NativeFieldInfoPtr_chargeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr, "chargeName");
				Offense.Charge.NativeFieldInfoPtr_crimeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr, "crimeIndex");
				Offense.Charge.NativeFieldInfoPtr_quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr, "quantity");
				Offense.Charge.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr, 100668038);
			}

			// Token: 0x0600C8E3 RID: 51427 RVA: 0x00311650 File Offset: 0x0030F850
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122636, XrefRangeEnd = 122642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Charge(string _chargeName, int _crimeIndex, int _quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(_chargeName);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _crimeIndex;
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _quantity;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Offense.Charge.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C8E4 RID: 51428 RVA: 0x000616C8 File Offset: 0x0005F8C8
			public Charge(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E69 RID: 15977
			// (get) Token: 0x0600C8E5 RID: 51429 RVA: 0x003116B8 File Offset: 0x0030F8B8
			// (set) Token: 0x0600C8E6 RID: 51430 RVA: 0x000616D1 File Offset: 0x0005F8D1
			public unsafe string chargeName
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.Charge.NativeFieldInfoPtr_chargeName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.Charge.NativeFieldInfoPtr_chargeName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003E6A RID: 15978
			// (get) Token: 0x0600C8E7 RID: 51431 RVA: 0x003116E0 File Offset: 0x0030F8E0
			// (set) Token: 0x0600C8E8 RID: 51432 RVA: 0x000616F0 File Offset: 0x0005F8F0
			public unsafe int crimeIndex
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.Charge.NativeFieldInfoPtr_crimeIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.Charge.NativeFieldInfoPtr_crimeIndex)) = value;
				}
			}

			// Token: 0x17003E6B RID: 15979
			// (get) Token: 0x0600C8E9 RID: 51433 RVA: 0x00311708 File Offset: 0x0030F908
			// (set) Token: 0x0600C8EA RID: 51434 RVA: 0x0006170B File Offset: 0x0005F90B
			public unsafe int quantity
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.Charge.NativeFieldInfoPtr_quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.Charge.NativeFieldInfoPtr_quantity)) = value;
				}
			}

			// Token: 0x0400883C RID: 34876
			private static readonly System.IntPtr NativeFieldInfoPtr_chargeName;

			// Token: 0x0400883D RID: 34877
			private static readonly System.IntPtr NativeFieldInfoPtr_crimeIndex;

			// Token: 0x0400883E RID: 34878
			private static readonly System.IntPtr NativeFieldInfoPtr_quantity;

			// Token: 0x0400883F RID: 34879
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0;
		}
	}
}
