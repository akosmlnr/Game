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
	// Token: 0x020005BA RID: 1466
	[System.Serializable]
	public class CocaineDefinition : ProductDefinition
	{
		// Token: 0x06007FE8 RID: 32744 RVA: 0x00225EA4 File Offset: 0x002240A4
		// Note: this type is marked as 'beforefieldinit'.
		static CocaineDefinition()
		{
			Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "CocaineDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr);
			CocaineDefinition.NativeFieldInfoPtr_RockMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, "RockMaterial");
			CocaineDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, "<AppearanceSettings>k__BackingField");
			CocaineDefinition.NativeMethodInfoPtr_get_AppearanceSettings_Public_get_CocaineAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679384);
			CocaineDefinition.NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_CocaineAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679385);
			CocaineDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679386);
			CocaineDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_CocaineAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679387);
			CocaineDefinition.NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679388);
			CocaineDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_CocaineAppearanceSettings_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679389);
			CocaineDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679390);
		}

		// Token: 0x17002687 RID: 9863
		// (get) Token: 0x06007FE9 RID: 32745 RVA: 0x00225F88 File Offset: 0x00224188
		// (set) Token: 0x06007FEA RID: 32746 RVA: 0x00225FC8 File Offset: 0x002241C8
		public unsafe CocaineAppearanceSettings AppearanceSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.NativeMethodInfoPtr_get_AppearanceSettings_Public_get_CocaineAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CocaineAppearanceSettings>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242031, XrefRangeEnd = 242032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_CocaineAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007FEB RID: 32747 RVA: 0x0022600C File Offset: 0x0022420C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242032, XrefRangeEnd = 242076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref quantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaineDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x06007FEC RID: 32748 RVA: 0x00226064 File Offset: 0x00224264
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 242095, RefRangeEnd = 242097, XrefRangeStart = 242076, XrefRangeEnd = 242095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(List<Property> properties, List<EDrugType> drugTypes, CocaineAppearanceSettings _appearance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(drugTypes);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_appearance);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_CocaineAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007FED RID: 32749 RVA: 0x002260CC File Offset: 0x002242CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242097, XrefRangeEnd = 242113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ProductData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaineDefinition.NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductData>(intPtr2) : null;
		}

		// Token: 0x06007FEE RID: 32750 RVA: 0x00226118 File Offset: 0x00224318
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 242190, RefRangeEnd = 242192, XrefRangeStart = 242113, XrefRangeEnd = 242190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CocaineAppearanceSettings GetAppearanceSettings(List<Property> properties)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_CocaineAppearanceSettings_List_1_Property_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CocaineAppearanceSettings>(intPtr2) : null;
		}

		// Token: 0x06007FEF RID: 32751 RVA: 0x0022615C File Offset: 0x0022435C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242192, XrefRangeEnd = 242193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007FF0 RID: 32752 RVA: 0x0003C8F9 File Offset: 0x0003AAF9
		public CocaineDefinition(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002685 RID: 9861
		// (get) Token: 0x06007FF1 RID: 32753 RVA: 0x00226198 File Offset: 0x00224398
		// (set) Token: 0x06007FF2 RID: 32754 RVA: 0x0003C902 File Offset: 0x0003AB02
		public unsafe Material RockMaterial
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineDefinition.NativeFieldInfoPtr_RockMaterial);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineDefinition.NativeFieldInfoPtr_RockMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002686 RID: 9862
		// (get) Token: 0x06007FF3 RID: 32755 RVA: 0x002261C8 File Offset: 0x002243C8
		// (set) Token: 0x06007FF4 RID: 32756 RVA: 0x0003C921 File Offset: 0x0003AB21
		public unsafe CocaineAppearanceSettings _AppearanceSettings_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CocaineAppearanceSettings>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005700 RID: 22272
		private static readonly System.IntPtr NativeFieldInfoPtr_RockMaterial;

		// Token: 0x04005701 RID: 22273
		private static readonly System.IntPtr NativeFieldInfoPtr__AppearanceSettings_k__BackingField;

		// Token: 0x04005702 RID: 22274
		private static readonly System.IntPtr NativeMethodInfoPtr_get_AppearanceSettings_Public_get_CocaineAppearanceSettings_0;

		// Token: 0x04005703 RID: 22275
		private static readonly System.IntPtr NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_CocaineAppearanceSettings_0;

		// Token: 0x04005704 RID: 22276
		private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005705 RID: 22277
		private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_CocaineAppearanceSettings_0;

		// Token: 0x04005706 RID: 22278
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0;

		// Token: 0x04005707 RID: 22279
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_CocaineAppearanceSettings_List_1_Property_0;

		// Token: 0x04005708 RID: 22280
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B12 RID: 2834
		[ObfuscatedName("ScheduleOne.Product.CocaineDefinition+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D938 RID: 55608 RVA: 0x0033FD7C File Offset: 0x0033DF7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr);
				CocaineDefinition.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr, "<>9");
				CocaineDefinition.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr, "<>9__8_0");
				CocaineDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr, 100679392);
				CocaineDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__8_0_Internal_Int32_Property_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr, 100679393);
			}

			// Token: 0x0600D939 RID: 55609 RVA: 0x0033FDF8 File Offset: 0x0033DFF8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D93A RID: 55610 RVA: 0x0033FE34 File Offset: 0x0033E034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242029, XrefRangeEnd = 242031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetAppearanceSettings_b__8_0(Property x, Property y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__8_0_Internal_Int32_Property_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D93B RID: 55611 RVA: 0x00069684 File Offset: 0x00067884
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004309 RID: 17161
			// (get) Token: 0x0600D93C RID: 55612 RVA: 0x0033FE94 File Offset: 0x0033E094
			// (set) Token: 0x0600D93D RID: 55613 RVA: 0x0006968D File Offset: 0x0006788D
			public unsafe static CocaineDefinition.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CocaineDefinition.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CocaineDefinition.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CocaineDefinition.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700430A RID: 17162
			// (get) Token: 0x0600D93E RID: 55614 RVA: 0x0033FEBC File Offset: 0x0033E0BC
			// (set) Token: 0x0600D93F RID: 55615 RVA: 0x0006969F File Offset: 0x0006789F
			public unsafe static Il2CppSystem.Comparison<Property> __9__8_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CocaineDefinition.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<Property>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CocaineDefinition.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009255 RID: 37461
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009256 RID: 37462
			private static readonly System.IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04009257 RID: 37463
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009258 RID: 37464
			private static readonly System.IntPtr NativeMethodInfoPtr__GetAppearanceSettings_b__8_0_Internal_Int32_Property_Property_0;
		}
	}
}
