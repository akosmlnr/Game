using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Properties;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005D3 RID: 1491
	[System.Serializable]
	public class WeedDefinition : ProductDefinition
	{
		// Token: 0x0600821B RID: 33307 RVA: 0x0022F1E0 File Offset: 0x0022D3E0
		// Note: this type is marked as 'beforefieldinit'.
		static WeedDefinition()
		{
			Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "WeedDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr);
			WeedDefinition.NativeFieldInfoPtr_MainMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, "MainMat");
			WeedDefinition.NativeFieldInfoPtr_SecondaryMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, "SecondaryMat");
			WeedDefinition.NativeFieldInfoPtr_LeafMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, "LeafMat");
			WeedDefinition.NativeFieldInfoPtr_StemMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, "StemMat");
			WeedDefinition.NativeFieldInfoPtr_appearance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, "appearance");
			WeedDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, 100679738);
			WeedDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_WeedAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, 100679739);
			WeedDefinition.NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, 100679740);
			WeedDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_WeedAppearanceSettings_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, 100679741);
			WeedDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, 100679742);
		}

		// Token: 0x0600821C RID: 33308 RVA: 0x0022F2D8 File Offset: 0x0022D4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247378, XrefRangeEnd = 247382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref quantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeedDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x0600821D RID: 33309 RVA: 0x0022F330 File Offset: 0x0022D530
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 247416, RefRangeEnd = 247418, XrefRangeStart = 247382, XrefRangeEnd = 247416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(List<Property> properties, List<EDrugType> drugTypes, WeedAppearanceSettings _appearance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(drugTypes);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_appearance);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_WeedAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600821E RID: 33310 RVA: 0x0022F398 File Offset: 0x0022D598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247418, XrefRangeEnd = 247434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ProductData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeedDefinition.NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductData>(intPtr2) : null;
		}

		// Token: 0x0600821F RID: 33311 RVA: 0x0022F3E4 File Offset: 0x0022D5E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 247514, RefRangeEnd = 247516, XrefRangeStart = 247434, XrefRangeEnd = 247514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WeedAppearanceSettings GetAppearanceSettings(List<Property> properties)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_WeedAppearanceSettings_List_1_Property_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeedAppearanceSettings>(intPtr2) : null;
		}

		// Token: 0x06008220 RID: 33312 RVA: 0x0022F428 File Offset: 0x0022D628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008221 RID: 33313 RVA: 0x0003D6B4 File Offset: 0x0003B8B4
		public WeedDefinition(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002718 RID: 10008
		// (get) Token: 0x06008222 RID: 33314 RVA: 0x0022F464 File Offset: 0x0022D664
		// (set) Token: 0x06008223 RID: 33315 RVA: 0x0003D6BD File Offset: 0x0003B8BD
		public unsafe Material MainMat
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_MainMat);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_MainMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002719 RID: 10009
		// (get) Token: 0x06008224 RID: 33316 RVA: 0x0022F494 File Offset: 0x0022D694
		// (set) Token: 0x06008225 RID: 33317 RVA: 0x0003D6DC File Offset: 0x0003B8DC
		public unsafe Material SecondaryMat
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_SecondaryMat);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_SecondaryMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700271A RID: 10010
		// (get) Token: 0x06008226 RID: 33318 RVA: 0x0022F4C4 File Offset: 0x0022D6C4
		// (set) Token: 0x06008227 RID: 33319 RVA: 0x0003D6FB File Offset: 0x0003B8FB
		public unsafe Material LeafMat
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_LeafMat);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_LeafMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700271B RID: 10011
		// (get) Token: 0x06008228 RID: 33320 RVA: 0x0022F4F4 File Offset: 0x0022D6F4
		// (set) Token: 0x06008229 RID: 33321 RVA: 0x0003D71A File Offset: 0x0003B91A
		public unsafe Material StemMat
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_StemMat);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_StemMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700271C RID: 10012
		// (get) Token: 0x0600822A RID: 33322 RVA: 0x0022F524 File Offset: 0x0022D724
		// (set) Token: 0x0600822B RID: 33323 RVA: 0x0003D739 File Offset: 0x0003B939
		public unsafe WeedAppearanceSettings appearance
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_appearance);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeedAppearanceSettings>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_appearance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040058AB RID: 22699
		private static readonly System.IntPtr NativeFieldInfoPtr_MainMat;

		// Token: 0x040058AC RID: 22700
		private static readonly System.IntPtr NativeFieldInfoPtr_SecondaryMat;

		// Token: 0x040058AD RID: 22701
		private static readonly System.IntPtr NativeFieldInfoPtr_LeafMat;

		// Token: 0x040058AE RID: 22702
		private static readonly System.IntPtr NativeFieldInfoPtr_StemMat;

		// Token: 0x040058AF RID: 22703
		private static readonly System.IntPtr NativeFieldInfoPtr_appearance;

		// Token: 0x040058B0 RID: 22704
		private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x040058B1 RID: 22705
		private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_WeedAppearanceSettings_0;

		// Token: 0x040058B2 RID: 22706
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0;

		// Token: 0x040058B3 RID: 22707
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_WeedAppearanceSettings_List_1_Property_0;

		// Token: 0x040058B4 RID: 22708
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B2B RID: 2859
		[ObfuscatedName("ScheduleOne.Product.WeedDefinition+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DA17 RID: 55831 RVA: 0x00342434 File Offset: 0x00340634
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr);
				WeedDefinition.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr, "<>9");
				WeedDefinition.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr, "<>9__8_0");
				WeedDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr, 100679744);
				WeedDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__8_0_Internal_Int32_Property_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr, 100679745);
			}

			// Token: 0x0600DA18 RID: 55832 RVA: 0x003424B0 File Offset: 0x003406B0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DA19 RID: 55833 RVA: 0x003424EC File Offset: 0x003406EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetAppearanceSettings_b__8_0(Property x, Property y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeedDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__8_0_Internal_Int32_Property_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DA1A RID: 55834 RVA: 0x00069CE4 File Offset: 0x00067EE4
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004344 RID: 17220
			// (get) Token: 0x0600DA1B RID: 55835 RVA: 0x0034254C File Offset: 0x0034074C
			// (set) Token: 0x0600DA1C RID: 55836 RVA: 0x00069CED File Offset: 0x00067EED
			public unsafe static WeedDefinition.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WeedDefinition.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeedDefinition.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WeedDefinition.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004345 RID: 17221
			// (get) Token: 0x0600DA1D RID: 55837 RVA: 0x00342574 File Offset: 0x00340774
			// (set) Token: 0x0600DA1E RID: 55838 RVA: 0x00069CFF File Offset: 0x00067EFF
			public unsafe static Il2CppSystem.Comparison<Property> __9__8_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WeedDefinition.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<Property>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WeedDefinition.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092C9 RID: 37577
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040092CA RID: 37578
			private static readonly System.IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x040092CB RID: 37579
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092CC RID: 37580
			private static readonly System.IntPtr NativeMethodInfoPtr__GetAppearanceSettings_b__8_0_Internal_Int32_Property_Property_0;
		}
	}
}
