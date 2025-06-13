using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Properties;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005D1 RID: 1489
	public class PropertyUtility : Singleton<PropertyUtility>
	{
		// Token: 0x060081F8 RID: 33272 RVA: 0x0022EB1C File Offset: 0x0022CD1C
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyUtility()
		{
			Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "PropertyUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr);
			PropertyUtility.NativeFieldInfoPtr_PropertyDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "PropertyDatas");
			PropertyUtility.NativeFieldInfoPtr_DrugTypeDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "DrugTypeDatas");
			PropertyUtility.NativeFieldInfoPtr_AllProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "AllProperties");
			PropertyUtility.NativeFieldInfoPtr_Products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "Products");
			PropertyUtility.NativeFieldInfoPtr_Properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "Properties");
			PropertyUtility.NativeFieldInfoPtr_PropertiesDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "PropertiesDict");
			PropertyUtility.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679712);
			PropertyUtility.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679713);
			PropertyUtility.NativeMethodInfoPtr_GetProperties_Public_List_1_Property_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679714);
			PropertyUtility.NativeMethodInfoPtr_GetProperties_Public_List_1_Property_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679715);
			PropertyUtility.NativeMethodInfoPtr_GetPropertyData_Public_Static_PropertyData_EProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679716);
			PropertyUtility.NativeMethodInfoPtr_GetDrugTypeData_Public_Static_DrugTypeData_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679717);
			PropertyUtility.NativeMethodInfoPtr_GetOrderedPropertyColors_Public_Static_List_1_Color32_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679718);
			PropertyUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679719);
		}

		// Token: 0x060081F9 RID: 33273 RVA: 0x0022EC64 File Offset: 0x0022CE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247124, XrefRangeEnd = 247144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyUtility.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060081FA RID: 33274 RVA: 0x0022ECA0 File Offset: 0x0022CEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247144, XrefRangeEnd = 247147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyUtility.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060081FB RID: 33275 RVA: 0x0022ECDC File Offset: 0x0022CEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247147, XrefRangeEnd = 247166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Property> GetProperties(int tier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref tier;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.NativeMethodInfoPtr_GetProperties_Public_List_1_Property_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr2) : null;
		}

		// Token: 0x060081FC RID: 33276 RVA: 0x0022ED28 File Offset: 0x0022CF28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 247234, RefRangeEnd = 247237, XrefRangeStart = 247166, XrefRangeEnd = 247234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Property> GetProperties(List<string> ids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.NativeMethodInfoPtr_GetProperties_Public_List_1_Property_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr2) : null;
		}

		// Token: 0x060081FD RID: 33277 RVA: 0x0022ED78 File Offset: 0x0022CF78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 247255, RefRangeEnd = 247258, XrefRangeStart = 247237, XrefRangeEnd = 247255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyUtility.PropertyData GetPropertyData(EProperty property)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref property;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.NativeMethodInfoPtr_GetPropertyData_Public_Static_PropertyData_EProperty_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyUtility.PropertyData>(intPtr2) : null;
		}

		// Token: 0x060081FE RID: 33278 RVA: 0x0022EDB8 File Offset: 0x0022CFB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 247276, RefRangeEnd = 247279, XrefRangeStart = 247258, XrefRangeEnd = 247276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyUtility.DrugTypeData GetDrugTypeData(EDrugType drugType)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref drugType;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.NativeMethodInfoPtr_GetDrugTypeData_Public_Static_DrugTypeData_EDrugType_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyUtility.DrugTypeData>(intPtr2) : null;
		}

		// Token: 0x060081FF RID: 33279 RVA: 0x0022EDF8 File Offset: 0x0022CFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247279, XrefRangeEnd = 247330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Color32> GetOrderedPropertyColors(List<Property> properties)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.NativeMethodInfoPtr_GetOrderedPropertyColors_Public_Static_List_1_Color32_List_1_Property_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Color32>>(intPtr2) : null;
		}

		// Token: 0x06008200 RID: 33280 RVA: 0x0022EE3C File Offset: 0x0022D03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247330, XrefRangeEnd = 247375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008201 RID: 33281 RVA: 0x0003D57C File Offset: 0x0003B77C
		public PropertyUtility(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700270E RID: 9998
		// (get) Token: 0x06008202 RID: 33282 RVA: 0x0022EE78 File Offset: 0x0022D078
		// (set) Token: 0x06008203 RID: 33283 RVA: 0x0003D585 File Offset: 0x0003B785
		public unsafe List<PropertyUtility.PropertyData> PropertyDatas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_PropertyDatas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PropertyUtility.PropertyData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_PropertyDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700270F RID: 9999
		// (get) Token: 0x06008204 RID: 33284 RVA: 0x0022EEA8 File Offset: 0x0022D0A8
		// (set) Token: 0x06008205 RID: 33285 RVA: 0x0003D5A4 File Offset: 0x0003B7A4
		public unsafe List<PropertyUtility.DrugTypeData> DrugTypeDatas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_DrugTypeDatas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PropertyUtility.DrugTypeData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_DrugTypeDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002710 RID: 10000
		// (get) Token: 0x06008206 RID: 33286 RVA: 0x0022EED8 File Offset: 0x0022D0D8
		// (set) Token: 0x06008207 RID: 33287 RVA: 0x0003D5C3 File Offset: 0x0003B7C3
		public unsafe List<Property> AllProperties
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_AllProperties);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_AllProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002711 RID: 10001
		// (get) Token: 0x06008208 RID: 33288 RVA: 0x0022EF08 File Offset: 0x0022D108
		// (set) Token: 0x06008209 RID: 33289 RVA: 0x0003D5E2 File Offset: 0x0003B7E2
		public unsafe List<ProductDefinition> Products
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_Products);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_Products), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002712 RID: 10002
		// (get) Token: 0x0600820A RID: 33290 RVA: 0x0022EF38 File Offset: 0x0022D138
		// (set) Token: 0x0600820B RID: 33291 RVA: 0x0003D601 File Offset: 0x0003B801
		public unsafe List<PropertyItemDefinition> Properties
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_Properties);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PropertyItemDefinition>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_Properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002713 RID: 10003
		// (get) Token: 0x0600820C RID: 33292 RVA: 0x0022EF68 File Offset: 0x0022D168
		// (set) Token: 0x0600820D RID: 33293 RVA: 0x0003D620 File Offset: 0x0003B820
		public unsafe Dictionary<string, Property> PropertiesDict
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_PropertiesDict);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Property>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_PropertiesDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005896 RID: 22678
		private static readonly System.IntPtr NativeFieldInfoPtr_PropertyDatas;

		// Token: 0x04005897 RID: 22679
		private static readonly System.IntPtr NativeFieldInfoPtr_DrugTypeDatas;

		// Token: 0x04005898 RID: 22680
		private static readonly System.IntPtr NativeFieldInfoPtr_AllProperties;

		// Token: 0x04005899 RID: 22681
		private static readonly System.IntPtr NativeFieldInfoPtr_Products;

		// Token: 0x0400589A RID: 22682
		private static readonly System.IntPtr NativeFieldInfoPtr_Properties;

		// Token: 0x0400589B RID: 22683
		private static readonly System.IntPtr NativeFieldInfoPtr_PropertiesDict;

		// Token: 0x0400589C RID: 22684
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400589D RID: 22685
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400589E RID: 22686
		private static readonly System.IntPtr NativeMethodInfoPtr_GetProperties_Public_List_1_Property_Int32_0;

		// Token: 0x0400589F RID: 22687
		private static readonly System.IntPtr NativeMethodInfoPtr_GetProperties_Public_List_1_Property_List_1_String_0;

		// Token: 0x040058A0 RID: 22688
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPropertyData_Public_Static_PropertyData_EProperty_0;

		// Token: 0x040058A1 RID: 22689
		private static readonly System.IntPtr NativeMethodInfoPtr_GetDrugTypeData_Public_Static_DrugTypeData_EDrugType_0;

		// Token: 0x040058A2 RID: 22690
		private static readonly System.IntPtr NativeMethodInfoPtr_GetOrderedPropertyColors_Public_Static_List_1_Color32_List_1_Property_0;

		// Token: 0x040058A3 RID: 22691
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B23 RID: 2851
		[System.Serializable]
		public class PropertyData : Il2CppSystem.Object
		{
			// Token: 0x0600D9DB RID: 55771 RVA: 0x00341A60 File Offset: 0x0033FC60
			// Note: this type is marked as 'beforefieldinit'.
			static PropertyData()
			{
				Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "PropertyData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr);
				PropertyUtility.PropertyData.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr, "Property");
				PropertyUtility.PropertyData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr, "Name");
				PropertyUtility.PropertyData.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr, "Description");
				PropertyUtility.PropertyData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr, "Color");
				PropertyUtility.PropertyData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr, 100679720);
			}

			// Token: 0x0600D9DC RID: 55772 RVA: 0x00341AF0 File Offset: 0x0033FCF0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PropertyData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.PropertyData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D9DD RID: 55773 RVA: 0x00069B05 File Offset: 0x00067D05
			public PropertyData(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004335 RID: 17205
			// (get) Token: 0x0600D9DE RID: 55774 RVA: 0x00341B2C File Offset: 0x0033FD2C
			// (set) Token: 0x0600D9DF RID: 55775 RVA: 0x00069B0E File Offset: 0x00067D0E
			public unsafe EProperty Property
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Property);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Property)) = value;
				}
			}

			// Token: 0x17004336 RID: 17206
			// (get) Token: 0x0600D9E0 RID: 55776 RVA: 0x00341B54 File Offset: 0x0033FD54
			// (set) Token: 0x0600D9E1 RID: 55777 RVA: 0x00069B29 File Offset: 0x00067D29
			public unsafe string Name
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004337 RID: 17207
			// (get) Token: 0x0600D9E2 RID: 55778 RVA: 0x00341B7C File Offset: 0x0033FD7C
			// (set) Token: 0x0600D9E3 RID: 55779 RVA: 0x00069B48 File Offset: 0x00067D48
			public unsafe string Description
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Description);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004338 RID: 17208
			// (get) Token: 0x0600D9E4 RID: 55780 RVA: 0x00341BA4 File Offset: 0x0033FDA4
			// (set) Token: 0x0600D9E5 RID: 55781 RVA: 0x00069B67 File Offset: 0x00067D67
			public unsafe Color Color
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Color)) = value;
				}
			}

			// Token: 0x040092AC RID: 37548
			private static readonly System.IntPtr NativeFieldInfoPtr_Property;

			// Token: 0x040092AD RID: 37549
			private static readonly System.IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x040092AE RID: 37550
			private static readonly System.IntPtr NativeFieldInfoPtr_Description;

			// Token: 0x040092AF RID: 37551
			private static readonly System.IntPtr NativeFieldInfoPtr_Color;

			// Token: 0x040092B0 RID: 37552
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B24 RID: 2852
		[System.Serializable]
		public class DrugTypeData : Il2CppSystem.Object
		{
			// Token: 0x0600D9E6 RID: 55782 RVA: 0x00341BCC File Offset: 0x0033FDCC
			// Note: this type is marked as 'beforefieldinit'.
			static DrugTypeData()
			{
				Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "DrugTypeData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr);
				PropertyUtility.DrugTypeData.NativeFieldInfoPtr_DrugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr, "DrugType");
				PropertyUtility.DrugTypeData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr, "Name");
				PropertyUtility.DrugTypeData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr, "Color");
				PropertyUtility.DrugTypeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr, 100679721);
			}

			// Token: 0x0600D9E7 RID: 55783 RVA: 0x00341C48 File Offset: 0x0033FE48
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DrugTypeData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.DrugTypeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D9E8 RID: 55784 RVA: 0x00069B82 File Offset: 0x00067D82
			public DrugTypeData(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004339 RID: 17209
			// (get) Token: 0x0600D9E9 RID: 55785 RVA: 0x00341C84 File Offset: 0x0033FE84
			// (set) Token: 0x0600D9EA RID: 55786 RVA: 0x00069B8B File Offset: 0x00067D8B
			public unsafe EDrugType DrugType
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.DrugTypeData.NativeFieldInfoPtr_DrugType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.DrugTypeData.NativeFieldInfoPtr_DrugType)) = value;
				}
			}

			// Token: 0x1700433A RID: 17210
			// (get) Token: 0x0600D9EB RID: 55787 RVA: 0x00341CAC File Offset: 0x0033FEAC
			// (set) Token: 0x0600D9EC RID: 55788 RVA: 0x00069BA6 File Offset: 0x00067DA6
			public unsafe string Name
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.DrugTypeData.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.DrugTypeData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700433B RID: 17211
			// (get) Token: 0x0600D9ED RID: 55789 RVA: 0x00341CD4 File Offset: 0x0033FED4
			// (set) Token: 0x0600D9EE RID: 55790 RVA: 0x00069BC5 File Offset: 0x00067DC5
			public unsafe Color Color
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.DrugTypeData.NativeFieldInfoPtr_Color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.DrugTypeData.NativeFieldInfoPtr_Color)) = value;
				}
			}

			// Token: 0x040092B1 RID: 37553
			private static readonly System.IntPtr NativeFieldInfoPtr_DrugType;

			// Token: 0x040092B2 RID: 37554
			private static readonly System.IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x040092B3 RID: 37555
			private static readonly System.IntPtr NativeFieldInfoPtr_Color;

			// Token: 0x040092B4 RID: 37556
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B25 RID: 2853
		[ObfuscatedName("ScheduleOne.Product.PropertyUtility+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D9EF RID: 55791 RVA: 0x00341CFC File Offset: 0x0033FEFC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr);
				PropertyUtility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr, "<>9");
				PropertyUtility.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr, "<>9__14_0");
				PropertyUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr, 100679723);
				PropertyUtility.__c.NativeMethodInfoPtr__GetOrderedPropertyColors_b__14_0_Internal_Int32_Property_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr, 100679724);
			}

			// Token: 0x0600D9F0 RID: 55792 RVA: 0x00341D78 File Offset: 0x0033FF78
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D9F1 RID: 55793 RVA: 0x00341DB4 File Offset: 0x0033FFB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetOrderedPropertyColors_b__14_0(Property x, Property y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c.NativeMethodInfoPtr__GetOrderedPropertyColors_b__14_0_Internal_Int32_Property_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D9F2 RID: 55794 RVA: 0x00069BE0 File Offset: 0x00067DE0
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700433C RID: 17212
			// (get) Token: 0x0600D9F3 RID: 55795 RVA: 0x00341E14 File Offset: 0x00340014
			// (set) Token: 0x0600D9F4 RID: 55796 RVA: 0x00069BE9 File Offset: 0x00067DE9
			public unsafe static PropertyUtility.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PropertyUtility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyUtility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PropertyUtility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700433D RID: 17213
			// (get) Token: 0x0600D9F5 RID: 55797 RVA: 0x00341E3C File Offset: 0x0034003C
			// (set) Token: 0x0600D9F6 RID: 55798 RVA: 0x00069BFB File Offset: 0x00067DFB
			public unsafe static Il2CppSystem.Comparison<Property> __9__14_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PropertyUtility.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<Property>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PropertyUtility.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092B5 RID: 37557
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040092B6 RID: 37558
			private static readonly System.IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x040092B7 RID: 37559
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092B8 RID: 37560
			private static readonly System.IntPtr NativeMethodInfoPtr__GetOrderedPropertyColors_b__14_0_Internal_Int32_Property_Property_0;
		}

		// Token: 0x02000B26 RID: 2854
		[ObfuscatedName("ScheduleOne.Product.PropertyUtility+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D9F7 RID: 55799 RVA: 0x00341E64 File Offset: 0x00340064
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr);
				PropertyUtility.__c__DisplayClass10_0.NativeFieldInfoPtr_tier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr, "tier");
				PropertyUtility.__c__DisplayClass10_0.NativeFieldInfoPtr_excludePostMixingRework = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr, "excludePostMixingRework");
				PropertyUtility.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr, 100679725);
				PropertyUtility.__c__DisplayClass10_0.NativeMethodInfoPtr__GetProperties_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr, 100679726);
			}

			// Token: 0x0600D9F8 RID: 55800 RVA: 0x00341EE0 File Offset: 0x003400E0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D9F9 RID: 55801 RVA: 0x00341F1C File Offset: 0x0034011C
			[CallerCount(0)]
			public unsafe bool _GetProperties_b__0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass10_0.NativeMethodInfoPtr__GetProperties_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D9FA RID: 55802 RVA: 0x00069C0D File Offset: 0x00067E0D
			public __c__DisplayClass10_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700433E RID: 17214
			// (get) Token: 0x0600D9FB RID: 55803 RVA: 0x00341F6C File Offset: 0x0034016C
			// (set) Token: 0x0600D9FC RID: 55804 RVA: 0x00069C16 File Offset: 0x00067E16
			public unsafe int tier
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass10_0.NativeFieldInfoPtr_tier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass10_0.NativeFieldInfoPtr_tier)) = value;
				}
			}

			// Token: 0x1700433F RID: 17215
			// (get) Token: 0x0600D9FD RID: 55805 RVA: 0x00341F94 File Offset: 0x00340194
			// (set) Token: 0x0600D9FE RID: 55806 RVA: 0x00069C31 File Offset: 0x00067E31
			public unsafe bool excludePostMixingRework
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass10_0.NativeFieldInfoPtr_excludePostMixingRework);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass10_0.NativeFieldInfoPtr_excludePostMixingRework)) = value;
				}
			}

			// Token: 0x040092B9 RID: 37561
			private static readonly System.IntPtr NativeFieldInfoPtr_tier;

			// Token: 0x040092BA RID: 37562
			private static readonly System.IntPtr NativeFieldInfoPtr_excludePostMixingRework;

			// Token: 0x040092BB RID: 37563
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092BC RID: 37564
			private static readonly System.IntPtr NativeMethodInfoPtr__GetProperties_b__0_Internal_Boolean_Property_0;
		}

		// Token: 0x02000B27 RID: 2855
		[ObfuscatedName("ScheduleOne.Product.PropertyUtility+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D9FF RID: 55807 RVA: 0x00341FBC File Offset: 0x003401BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_0>.NativeClassPtr);
				PropertyUtility.__c__DisplayClass11_0.NativeFieldInfoPtr_ids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_0>.NativeClassPtr, "ids");
				PropertyUtility.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_0>.NativeClassPtr, 100679727);
				PropertyUtility.__c__DisplayClass11_0.NativeMethodInfoPtr__GetProperties_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_0>.NativeClassPtr, 100679728);
			}

			// Token: 0x0600DA00 RID: 55808 RVA: 0x00342024 File Offset: 0x00340224
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DA01 RID: 55809 RVA: 0x00342060 File Offset: 0x00340260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247120, XrefRangeEnd = 247124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetProperties_b__0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass11_0.NativeMethodInfoPtr__GetProperties_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DA02 RID: 55810 RVA: 0x00069C4C File Offset: 0x00067E4C
			public __c__DisplayClass11_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004340 RID: 17216
			// (get) Token: 0x0600DA03 RID: 55811 RVA: 0x003420B0 File Offset: 0x003402B0
			// (set) Token: 0x0600DA04 RID: 55812 RVA: 0x00069C55 File Offset: 0x00067E55
			public unsafe List<string> ids
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass11_0.NativeFieldInfoPtr_ids);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass11_0.NativeFieldInfoPtr_ids), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092BD RID: 37565
			private static readonly System.IntPtr NativeFieldInfoPtr_ids;

			// Token: 0x040092BE RID: 37566
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092BF RID: 37567
			private static readonly System.IntPtr NativeMethodInfoPtr__GetProperties_b__0_Internal_Boolean_Property_0;
		}

		// Token: 0x02000B28 RID: 2856
		[ObfuscatedName("ScheduleOne.Product.PropertyUtility+<>c__DisplayClass11_1")]
		public sealed class __c__DisplayClass11_1 : Il2CppSystem.Object
		{
			// Token: 0x0600DA05 RID: 55813 RVA: 0x003420E0 File Offset: 0x003402E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_1()
			{
				Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "<>c__DisplayClass11_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_1>.NativeClassPtr);
				PropertyUtility.__c__DisplayClass11_1.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_1>.NativeClassPtr, "id");
				PropertyUtility.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_1>.NativeClassPtr, 100679729);
				PropertyUtility.__c__DisplayClass11_1.NativeMethodInfoPtr__GetProperties_b__1_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_1>.NativeClassPtr, 100679730);
			}

			// Token: 0x0600DA06 RID: 55814 RVA: 0x00342148 File Offset: 0x00340348
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_1>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DA07 RID: 55815 RVA: 0x00342184 File Offset: 0x00340384
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetProperties_b__1(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass11_1.NativeMethodInfoPtr__GetProperties_b__1_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DA08 RID: 55816 RVA: 0x00069C74 File Offset: 0x00067E74
			public __c__DisplayClass11_1(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004341 RID: 17217
			// (get) Token: 0x0600DA09 RID: 55817 RVA: 0x003421D4 File Offset: 0x003403D4
			// (set) Token: 0x0600DA0A RID: 55818 RVA: 0x00069C7D File Offset: 0x00067E7D
			public unsafe string id
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass11_1.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass11_1.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040092C0 RID: 37568
			private static readonly System.IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040092C1 RID: 37569
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092C2 RID: 37570
			private static readonly System.IntPtr NativeMethodInfoPtr__GetProperties_b__1_Internal_Boolean_Property_0;
		}

		// Token: 0x02000B29 RID: 2857
		[ObfuscatedName("ScheduleOne.Product.PropertyUtility+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA0B RID: 55819 RVA: 0x003421FC File Offset: 0x003403FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass12_0>.NativeClassPtr);
				PropertyUtility.__c__DisplayClass12_0.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass12_0>.NativeClassPtr, "property");
				PropertyUtility.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass12_0>.NativeClassPtr, 100679731);
				PropertyUtility.__c__DisplayClass12_0.NativeMethodInfoPtr__GetPropertyData_b__0_Internal_Boolean_PropertyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass12_0>.NativeClassPtr, 100679732);
			}

			// Token: 0x0600DA0C RID: 55820 RVA: 0x00342264 File Offset: 0x00340464
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass12_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DA0D RID: 55821 RVA: 0x003422A0 File Offset: 0x003404A0
			[CallerCount(0)]
			public unsafe bool _GetPropertyData_b__0(PropertyUtility.PropertyData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass12_0.NativeMethodInfoPtr__GetPropertyData_b__0_Internal_Boolean_PropertyData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DA0E RID: 55822 RVA: 0x00069C9C File Offset: 0x00067E9C
			public __c__DisplayClass12_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004342 RID: 17218
			// (get) Token: 0x0600DA0F RID: 55823 RVA: 0x003422F0 File Offset: 0x003404F0
			// (set) Token: 0x0600DA10 RID: 55824 RVA: 0x00069CA5 File Offset: 0x00067EA5
			public unsafe EProperty property
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass12_0.NativeFieldInfoPtr_property);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass12_0.NativeFieldInfoPtr_property)) = value;
				}
			}

			// Token: 0x040092C3 RID: 37571
			private static readonly System.IntPtr NativeFieldInfoPtr_property;

			// Token: 0x040092C4 RID: 37572
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092C5 RID: 37573
			private static readonly System.IntPtr NativeMethodInfoPtr__GetPropertyData_b__0_Internal_Boolean_PropertyData_0;
		}

		// Token: 0x02000B2A RID: 2858
		[ObfuscatedName("ScheduleOne.Product.PropertyUtility+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA11 RID: 55825 RVA: 0x00342318 File Offset: 0x00340518
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass13_0>.NativeClassPtr);
				PropertyUtility.__c__DisplayClass13_0.NativeFieldInfoPtr_drugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass13_0>.NativeClassPtr, "drugType");
				PropertyUtility.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass13_0>.NativeClassPtr, 100679733);
				PropertyUtility.__c__DisplayClass13_0.NativeMethodInfoPtr__GetDrugTypeData_b__0_Internal_Boolean_DrugTypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass13_0>.NativeClassPtr, 100679734);
			}

			// Token: 0x0600DA12 RID: 55826 RVA: 0x00342380 File Offset: 0x00340580
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass13_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DA13 RID: 55827 RVA: 0x003423BC File Offset: 0x003405BC
			[CallerCount(0)]
			public unsafe bool _GetDrugTypeData_b__0(PropertyUtility.DrugTypeData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass13_0.NativeMethodInfoPtr__GetDrugTypeData_b__0_Internal_Boolean_DrugTypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DA14 RID: 55828 RVA: 0x00069CC0 File Offset: 0x00067EC0
			public __c__DisplayClass13_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004343 RID: 17219
			// (get) Token: 0x0600DA15 RID: 55829 RVA: 0x0034240C File Offset: 0x0034060C
			// (set) Token: 0x0600DA16 RID: 55830 RVA: 0x00069CC9 File Offset: 0x00067EC9
			public unsafe EDrugType drugType
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass13_0.NativeFieldInfoPtr_drugType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass13_0.NativeFieldInfoPtr_drugType)) = value;
				}
			}

			// Token: 0x040092C6 RID: 37574
			private static readonly System.IntPtr NativeFieldInfoPtr_drugType;

			// Token: 0x040092C7 RID: 37575
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092C8 RID: 37576
			private static readonly System.IntPtr NativeMethodInfoPtr__GetDrugTypeData_b__0_Internal_Boolean_DrugTypeData_0;
		}
	}
}
