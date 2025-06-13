using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.Properties
{
	// Token: 0x020001FB RID: 507
	public static class PropertyMixCalculator : Il2CppSystem.Object
	{
		// Token: 0x060028DE RID: 10462 RVA: 0x000F49CC File Offset: 0x000F2BCC
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyMixCalculator()
		{
			Il2CppClassPointerStore<PropertyMixCalculator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties", "PropertyMixCalculator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyMixCalculator>.NativeClassPtr);
			PropertyMixCalculator.NativeFieldInfoPtr_MAX_PROPERTIES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyMixCalculator>.NativeClassPtr, "MAX_PROPERTIES");
			PropertyMixCalculator.NativeFieldInfoPtr_MAX_DELTA_DIFFERENCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyMixCalculator>.NativeClassPtr, "MAX_DELTA_DIFFERENCE");
			PropertyMixCalculator.NativeMethodInfoPtr_MixProperties_Public_Static_List_1_Property_List_1_Property_Property_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMixCalculator>.NativeClassPtr, 100667945);
			PropertyMixCalculator.NativeMethodInfoPtr_Shuffle_Public_Static_Void_List_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMixCalculator>.NativeClassPtr, 100667946);
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x000F4A4C File Offset: 0x000F2C4C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 121902, RefRangeEnd = 121911, XrefRangeStart = 121805, XrefRangeEnd = 121902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Property> MixProperties(List<Property> existingProperties, Property newProperty, EDrugType drugType)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(existingProperties);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newProperty);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref drugType;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMixCalculator.NativeMethodInfoPtr_MixProperties_Public_Static_List_1_Property_List_1_Property_Property_EDrugType_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr2) : null;
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x000F4AB0 File Offset: 0x000F2CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121911, XrefRangeEnd = 121923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Shuffle<T>(List<T> list, int seed)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref seed;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMixCalculator.MethodInfoStoreGeneric_Shuffle_Public_Static_Void_List_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x000161E6 File Offset: 0x000143E6
		public PropertyMixCalculator(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x060028E2 RID: 10466 RVA: 0x000F4AF4 File Offset: 0x000F2CF4
		// (set) Token: 0x060028E3 RID: 10467 RVA: 0x000161EF File Offset: 0x000143EF
		public unsafe static int MAX_PROPERTIES
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PropertyMixCalculator.NativeFieldInfoPtr_MAX_PROPERTIES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PropertyMixCalculator.NativeFieldInfoPtr_MAX_PROPERTIES, (void*)(&value));
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x060028E4 RID: 10468 RVA: 0x000F4B10 File Offset: 0x000F2D10
		// (set) Token: 0x060028E5 RID: 10469 RVA: 0x000161FD File Offset: 0x000143FD
		public unsafe static float MAX_DELTA_DIFFERENCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PropertyMixCalculator.NativeFieldInfoPtr_MAX_DELTA_DIFFERENCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PropertyMixCalculator.NativeFieldInfoPtr_MAX_DELTA_DIFFERENCE, (void*)(&value));
			}
		}

		// Token: 0x04001B23 RID: 6947
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_PROPERTIES;

		// Token: 0x04001B24 RID: 6948
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_DELTA_DIFFERENCE;

		// Token: 0x04001B25 RID: 6949
		private static readonly System.IntPtr NativeMethodInfoPtr_MixProperties_Public_Static_List_1_Property_List_1_Property_Property_EDrugType_0;

		// Token: 0x04001B26 RID: 6950
		private static readonly System.IntPtr NativeMethodInfoPtr_Shuffle_Public_Static_Void_List_1_T_Int32_0;

		// Token: 0x02000908 RID: 2312
		public class Reaction : Il2CppSystem.Object
		{
			// Token: 0x0600C8A2 RID: 51362 RVA: 0x00310A84 File Offset: 0x0030EC84
			// Note: this type is marked as 'beforefieldinit'.
			static Reaction()
			{
				Il2CppClassPointerStore<PropertyMixCalculator.Reaction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyMixCalculator>.NativeClassPtr, "Reaction");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyMixCalculator.Reaction>.NativeClassPtr);
				PropertyMixCalculator.Reaction.NativeFieldInfoPtr_Existing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyMixCalculator.Reaction>.NativeClassPtr, "Existing");
				PropertyMixCalculator.Reaction.NativeFieldInfoPtr_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyMixCalculator.Reaction>.NativeClassPtr, "Output");
				PropertyMixCalculator.Reaction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMixCalculator.Reaction>.NativeClassPtr, 100667947);
			}

			// Token: 0x0600C8A3 RID: 51363 RVA: 0x00310AEC File Offset: 0x0030ECEC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Reaction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyMixCalculator.Reaction>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMixCalculator.Reaction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C8A4 RID: 51364 RVA: 0x00061468 File Offset: 0x0005F668
			public Reaction(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E54 RID: 15956
			// (get) Token: 0x0600C8A5 RID: 51365 RVA: 0x00310B28 File Offset: 0x0030ED28
			// (set) Token: 0x0600C8A6 RID: 51366 RVA: 0x00061471 File Offset: 0x0005F671
			public unsafe Property Existing
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMixCalculator.Reaction.NativeFieldInfoPtr_Existing);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMixCalculator.Reaction.NativeFieldInfoPtr_Existing), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E55 RID: 15957
			// (get) Token: 0x0600C8A7 RID: 51367 RVA: 0x00310B58 File Offset: 0x0030ED58
			// (set) Token: 0x0600C8A8 RID: 51368 RVA: 0x00061490 File Offset: 0x0005F690
			public unsafe Property Output
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMixCalculator.Reaction.NativeFieldInfoPtr_Output);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMixCalculator.Reaction.NativeFieldInfoPtr_Output), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008814 RID: 34836
			private static readonly System.IntPtr NativeFieldInfoPtr_Existing;

			// Token: 0x04008815 RID: 34837
			private static readonly System.IntPtr NativeFieldInfoPtr_Output;

			// Token: 0x04008816 RID: 34838
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000909 RID: 2313
		private sealed class MethodInfoStoreGeneric_Shuffle_Public_Static_Void_List_1_T_Int32_0<T>
		{
			// Token: 0x04008817 RID: 34839
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PropertyMixCalculator.NativeMethodInfoPtr_Shuffle_Public_Static_Void_List_1_T_Int32_0, Il2CppClassPointerStore<PropertyMixCalculator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
