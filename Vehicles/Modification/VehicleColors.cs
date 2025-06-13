using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.Modification
{
	// Token: 0x0200051C RID: 1308
	public class VehicleColors : Singleton<VehicleColors>
	{
		// Token: 0x0600729B RID: 29339 RVA: 0x001F9934 File Offset: 0x001F7B34
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleColors()
		{
			Il2CppClassPointerStore<VehicleColors>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.Modification", "VehicleColors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr);
			VehicleColors.NativeFieldInfoPtr_colorLibrary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, "colorLibrary");
			VehicleColors.NativeMethodInfoPtr_GetColorName_Public_String_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, 100677787);
			VehicleColors.NativeMethodInfoPtr_GetColorUIColor_Public_Color32_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, 100677788);
			VehicleColors.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, 100677789);
		}

		// Token: 0x0600729C RID: 29340 RVA: 0x001F99B4 File Offset: 0x001F7BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225672, XrefRangeEnd = 225685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetColorName(EVehicleColor c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref c;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(VehicleColors.NativeMethodInfoPtr_GetColorName_Public_String_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600729D RID: 29341 RVA: 0x001F99F8 File Offset: 0x001F7BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225685, XrefRangeEnd = 225698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color32 GetColorUIColor(EVehicleColor c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref c;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleColors.NativeMethodInfoPtr_GetColorUIColor_Public_Color32_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600729E RID: 29342 RVA: 0x001F9A44 File Offset: 0x001F7C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225698, XrefRangeEnd = 225708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleColors() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600729F RID: 29343 RVA: 0x000362D3 File Offset: 0x000344D3
		public VehicleColors(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002273 RID: 8819
		// (get) Token: 0x060072A0 RID: 29344 RVA: 0x001F9A80 File Offset: 0x001F7C80
		// (set) Token: 0x060072A1 RID: 29345 RVA: 0x000362DC File Offset: 0x000344DC
		public unsafe List<VehicleColors.VehicleColorData> colorLibrary
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.NativeFieldInfoPtr_colorLibrary);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VehicleColors.VehicleColorData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.NativeFieldInfoPtr_colorLibrary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004E55 RID: 20053
		private static readonly System.IntPtr NativeFieldInfoPtr_colorLibrary;

		// Token: 0x04004E56 RID: 20054
		private static readonly System.IntPtr NativeMethodInfoPtr_GetColorName_Public_String_EVehicleColor_0;

		// Token: 0x04004E57 RID: 20055
		private static readonly System.IntPtr NativeMethodInfoPtr_GetColorUIColor_Public_Color32_EVehicleColor_0;

		// Token: 0x04004E58 RID: 20056
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000ABA RID: 2746
		[System.Serializable]
		public class VehicleColorData : Il2CppSystem.Object
		{
			// Token: 0x0600D659 RID: 54873 RVA: 0x00337B18 File Offset: 0x00335D18
			// Note: this type is marked as 'beforefieldinit'.
			static VehicleColorData()
			{
				Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, "VehicleColorData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr);
				VehicleColors.VehicleColorData.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr, "color");
				VehicleColors.VehicleColorData.NativeFieldInfoPtr_colorName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr, "colorName");
				VehicleColors.VehicleColorData.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr, "material");
				VehicleColors.VehicleColorData.NativeFieldInfoPtr_UIColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr, "UIColor");
				VehicleColors.VehicleColorData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr, 100677790);
			}

			// Token: 0x0600D65A RID: 54874 RVA: 0x00337BA8 File Offset: 0x00335DA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225670, XrefRangeEnd = 225672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VehicleColorData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.VehicleColorData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D65B RID: 54875 RVA: 0x00068076 File Offset: 0x00066276
			public VehicleColorData(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700423F RID: 16959
			// (get) Token: 0x0600D65C RID: 54876 RVA: 0x00337BE4 File Offset: 0x00335DE4
			// (set) Token: 0x0600D65D RID: 54877 RVA: 0x0006807F File Offset: 0x0006627F
			public unsafe EVehicleColor color
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x17004240 RID: 16960
			// (get) Token: 0x0600D65E RID: 54878 RVA: 0x00337C0C File Offset: 0x00335E0C
			// (set) Token: 0x0600D65F RID: 54879 RVA: 0x0006809A File Offset: 0x0006629A
			public unsafe string colorName
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_colorName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_colorName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004241 RID: 16961
			// (get) Token: 0x0600D660 RID: 54880 RVA: 0x00337C34 File Offset: 0x00335E34
			// (set) Token: 0x0600D661 RID: 54881 RVA: 0x000680B9 File Offset: 0x000662B9
			public unsafe Material material
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_material);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004242 RID: 16962
			// (get) Token: 0x0600D662 RID: 54882 RVA: 0x00337C64 File Offset: 0x00335E64
			// (set) Token: 0x0600D663 RID: 54883 RVA: 0x000680D8 File Offset: 0x000662D8
			public unsafe Color32 UIColor
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_UIColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_UIColor)) = value;
				}
			}

			// Token: 0x040090AA RID: 37034
			private static readonly System.IntPtr NativeFieldInfoPtr_color;

			// Token: 0x040090AB RID: 37035
			private static readonly System.IntPtr NativeFieldInfoPtr_colorName;

			// Token: 0x040090AC RID: 37036
			private static readonly System.IntPtr NativeFieldInfoPtr_material;

			// Token: 0x040090AD RID: 37037
			private static readonly System.IntPtr NativeFieldInfoPtr_UIColor;

			// Token: 0x040090AE RID: 37038
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000ABB RID: 2747
		[ObfuscatedName("ScheduleOne.Vehicles.Modification.VehicleColors+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D664 RID: 54884 RVA: 0x00337C8C File Offset: 0x00335E8C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<VehicleColors.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass2_0>.NativeClassPtr);
				VehicleColors.__c__DisplayClass2_0.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass2_0>.NativeClassPtr, "c");
				VehicleColors.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass2_0>.NativeClassPtr, 100677791);
				VehicleColors.__c__DisplayClass2_0.NativeMethodInfoPtr__GetColorName_b__0_Internal_Boolean_VehicleColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass2_0>.NativeClassPtr, 100677792);
			}

			// Token: 0x0600D665 RID: 54885 RVA: 0x00337CF4 File Offset: 0x00335EF4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass2_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D666 RID: 54886 RVA: 0x00337D30 File Offset: 0x00335F30
			[CallerCount(0)]
			public unsafe bool _GetColorName_b__0(VehicleColors.VehicleColorData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleColors.__c__DisplayClass2_0.NativeMethodInfoPtr__GetColorName_b__0_Internal_Boolean_VehicleColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D667 RID: 54887 RVA: 0x000680F3 File Offset: 0x000662F3
			public __c__DisplayClass2_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004243 RID: 16963
			// (get) Token: 0x0600D668 RID: 54888 RVA: 0x00337D80 File Offset: 0x00335F80
			// (set) Token: 0x0600D669 RID: 54889 RVA: 0x000680FC File Offset: 0x000662FC
			public unsafe EVehicleColor c
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.__c__DisplayClass2_0.NativeFieldInfoPtr_c);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.__c__DisplayClass2_0.NativeFieldInfoPtr_c)) = value;
				}
			}

			// Token: 0x040090AF RID: 37039
			private static readonly System.IntPtr NativeFieldInfoPtr_c;

			// Token: 0x040090B0 RID: 37040
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040090B1 RID: 37041
			private static readonly System.IntPtr NativeMethodInfoPtr__GetColorName_b__0_Internal_Boolean_VehicleColorData_0;
		}

		// Token: 0x02000ABC RID: 2748
		[ObfuscatedName("ScheduleOne.Vehicles.Modification.VehicleColors+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D66A RID: 54890 RVA: 0x00337DA8 File Offset: 0x00335FA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<VehicleColors.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass3_0>.NativeClassPtr);
				VehicleColors.__c__DisplayClass3_0.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass3_0>.NativeClassPtr, "c");
				VehicleColors.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass3_0>.NativeClassPtr, 100677793);
				VehicleColors.__c__DisplayClass3_0.NativeMethodInfoPtr__GetColorUIColor_b__0_Internal_Boolean_VehicleColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass3_0>.NativeClassPtr, 100677794);
			}

			// Token: 0x0600D66B RID: 54891 RVA: 0x00337E10 File Offset: 0x00336010
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass3_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D66C RID: 54892 RVA: 0x00337E4C File Offset: 0x0033604C
			[CallerCount(0)]
			public unsafe bool _GetColorUIColor_b__0(VehicleColors.VehicleColorData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleColors.__c__DisplayClass3_0.NativeMethodInfoPtr__GetColorUIColor_b__0_Internal_Boolean_VehicleColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D66D RID: 54893 RVA: 0x00068117 File Offset: 0x00066317
			public __c__DisplayClass3_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004244 RID: 16964
			// (get) Token: 0x0600D66E RID: 54894 RVA: 0x00337E9C File Offset: 0x0033609C
			// (set) Token: 0x0600D66F RID: 54895 RVA: 0x00068120 File Offset: 0x00066320
			public unsafe EVehicleColor c
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.__c__DisplayClass3_0.NativeFieldInfoPtr_c);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.__c__DisplayClass3_0.NativeFieldInfoPtr_c)) = value;
				}
			}

			// Token: 0x040090B2 RID: 37042
			private static readonly System.IntPtr NativeFieldInfoPtr_c;

			// Token: 0x040090B3 RID: 37043
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040090B4 RID: 37044
			private static readonly System.IntPtr NativeMethodInfoPtr__GetColorUIColor_b__0_Internal_Boolean_VehicleColorData_0;
		}
	}
}
