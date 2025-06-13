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
	// Token: 0x020005C3 RID: 1475
	[System.Serializable]
	public class MethDefinition : ProductDefinition
	{
		// Token: 0x0600801C RID: 32796 RVA: 0x00226AE0 File Offset: 0x00224CE0
		// Note: this type is marked as 'beforefieldinit'.
		static MethDefinition()
		{
			Il2CppClassPointerStore<MethDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "MethDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr);
			MethDefinition.NativeFieldInfoPtr_CrystalMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, "CrystalMaterial");
			MethDefinition.NativeFieldInfoPtr_TintColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, "TintColor");
			MethDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, "<AppearanceSettings>k__BackingField");
			MethDefinition.NativeMethodInfoPtr_get_AppearanceSettings_Public_get_MethAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679413);
			MethDefinition.NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_MethAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679414);
			MethDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679415);
			MethDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_MethAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679416);
			MethDefinition.NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679417);
			MethDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_MethAppearanceSettings_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679418);
			MethDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679419);
		}

		// Token: 0x1700268F RID: 9871
		// (get) Token: 0x0600801D RID: 32797 RVA: 0x00226BD8 File Offset: 0x00224DD8
		// (set) Token: 0x0600801E RID: 32798 RVA: 0x00226C18 File Offset: 0x00224E18
		public unsafe MethAppearanceSettings AppearanceSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.NativeMethodInfoPtr_get_AppearanceSettings_Public_get_MethAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethAppearanceSettings>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_MethAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600801F RID: 32799 RVA: 0x00226C5C File Offset: 0x00224E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242320, XrefRangeEnd = 242364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref quantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x06008020 RID: 32800 RVA: 0x00226CB4 File Offset: 0x00224EB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 242383, RefRangeEnd = 242385, XrefRangeStart = 242364, XrefRangeEnd = 242383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(List<Property> properties, List<EDrugType> drugTypes, MethAppearanceSettings _appearance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(drugTypes);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_appearance);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_MethAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008021 RID: 32801 RVA: 0x00226D1C File Offset: 0x00224F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242385, XrefRangeEnd = 242401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ProductData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethDefinition.NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductData>(intPtr2) : null;
		}

		// Token: 0x06008022 RID: 32802 RVA: 0x00226D68 File Offset: 0x00224F68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 242478, RefRangeEnd = 242480, XrefRangeStart = 242401, XrefRangeEnd = 242478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethAppearanceSettings GetAppearanceSettings(List<Property> properties)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_MethAppearanceSettings_List_1_Property_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethAppearanceSettings>(intPtr2) : null;
		}

		// Token: 0x06008023 RID: 32803 RVA: 0x00226DAC File Offset: 0x00224FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242480, XrefRangeEnd = 242481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008024 RID: 32804 RVA: 0x0003C9E2 File Offset: 0x0003ABE2
		public MethDefinition(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700268C RID: 9868
		// (get) Token: 0x06008025 RID: 32805 RVA: 0x00226DE8 File Offset: 0x00224FE8
		// (set) Token: 0x06008026 RID: 32806 RVA: 0x0003C9EB File Offset: 0x0003ABEB
		public unsafe Material CrystalMaterial
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MethDefinition.NativeFieldInfoPtr_CrystalMaterial);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MethDefinition.NativeFieldInfoPtr_CrystalMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700268D RID: 9869
		// (get) Token: 0x06008027 RID: 32807 RVA: 0x00226E18 File Offset: 0x00225018
		// (set) Token: 0x06008028 RID: 32808 RVA: 0x0003CA0A File Offset: 0x0003AC0A
		public unsafe Color TintColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MethDefinition.NativeFieldInfoPtr_TintColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MethDefinition.NativeFieldInfoPtr_TintColor)) = value;
			}
		}

		// Token: 0x1700268E RID: 9870
		// (get) Token: 0x06008029 RID: 32809 RVA: 0x00226E40 File Offset: 0x00225040
		// (set) Token: 0x0600802A RID: 32810 RVA: 0x0003CA25 File Offset: 0x0003AC25
		public unsafe MethAppearanceSettings _AppearanceSettings_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MethDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethAppearanceSettings>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MethDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005739 RID: 22329
		private static readonly System.IntPtr NativeFieldInfoPtr_CrystalMaterial;

		// Token: 0x0400573A RID: 22330
		private static readonly System.IntPtr NativeFieldInfoPtr_TintColor;

		// Token: 0x0400573B RID: 22331
		private static readonly System.IntPtr NativeFieldInfoPtr__AppearanceSettings_k__BackingField;

		// Token: 0x0400573C RID: 22332
		private static readonly System.IntPtr NativeMethodInfoPtr_get_AppearanceSettings_Public_get_MethAppearanceSettings_0;

		// Token: 0x0400573D RID: 22333
		private static readonly System.IntPtr NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_MethAppearanceSettings_0;

		// Token: 0x0400573E RID: 22334
		private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x0400573F RID: 22335
		private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_MethAppearanceSettings_0;

		// Token: 0x04005740 RID: 22336
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0;

		// Token: 0x04005741 RID: 22337
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_MethAppearanceSettings_List_1_Property_0;

		// Token: 0x04005742 RID: 22338
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B13 RID: 2835
		[ObfuscatedName("ScheduleOne.Product.MethDefinition+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D940 RID: 55616 RVA: 0x0033FEE4 File Offset: 0x0033E0E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr);
				MethDefinition.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr, "<>9");
				MethDefinition.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr, "<>9__9_0");
				MethDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr, 100679421);
				MethDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__9_0_Internal_Int32_Property_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr, 100679422);
			}

			// Token: 0x0600D941 RID: 55617 RVA: 0x0033FF60 File Offset: 0x0033E160
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D942 RID: 55618 RVA: 0x0033FF9C File Offset: 0x0033E19C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetAppearanceSettings_b__9_0(Property x, Property y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MethDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__9_0_Internal_Int32_Property_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D943 RID: 55619 RVA: 0x000696B1 File Offset: 0x000678B1
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700430B RID: 17163
			// (get) Token: 0x0600D944 RID: 55620 RVA: 0x0033FFFC File Offset: 0x0033E1FC
			// (set) Token: 0x0600D945 RID: 55621 RVA: 0x000696BA File Offset: 0x000678BA
			public unsafe static MethDefinition.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MethDefinition.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethDefinition.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MethDefinition.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700430C RID: 17164
			// (get) Token: 0x0600D946 RID: 55622 RVA: 0x00340024 File Offset: 0x0033E224
			// (set) Token: 0x0600D947 RID: 55623 RVA: 0x000696CC File Offset: 0x000678CC
			public unsafe static Il2CppSystem.Comparison<Property> __9__9_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MethDefinition.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<Property>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MethDefinition.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009259 RID: 37465
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400925A RID: 37466
			private static readonly System.IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x0400925B RID: 37467
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400925C RID: 37468
			private static readonly System.IntPtr NativeMethodInfoPtr__GetAppearanceSettings_b__9_0_Internal_Int32_Property_Property_0;
		}
	}
}
