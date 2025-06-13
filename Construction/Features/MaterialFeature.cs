using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Construction.Features;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.Features
{
	// Token: 0x020004A8 RID: 1192
	public class MaterialFeature : OptionListFeature
	{
		// Token: 0x06006667 RID: 26215 RVA: 0x001D0E68 File Offset: 0x001CF068
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialFeature()
		{
			Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.Features", "MaterialFeature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr);
			MaterialFeature.NativeFieldInfoPtr_materialTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, "materialTargets");
			MaterialFeature.NativeFieldInfoPtr_materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, "materials");
			MaterialFeature.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Construction.Features.MaterialFeatureAssembly-CSharp.dll_Excuted");
			MaterialFeature.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Construction.Features.MaterialFeatureAssembly-CSharp.dll_Excuted");
			MaterialFeature.NativeMethodInfoPtr_SelectOption_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, 100676361);
			MaterialFeature.NativeMethodInfoPtr_ApplyMaterial_Private_Void_NamedMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, 100676362);
			MaterialFeature.NativeMethodInfoPtr_GetOptions_Protected_Virtual_List_1_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, 100676363);
			MaterialFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, 100676364);
			MaterialFeature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, 100676365);
			MaterialFeature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, 100676366);
			MaterialFeature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, 100676367);
			MaterialFeature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, 100676368);
		}

		// Token: 0x06006668 RID: 26216 RVA: 0x001D0F88 File Offset: 0x001CF188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208820, XrefRangeEnd = 208829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SelectOption(int optionIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref optionIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialFeature.NativeMethodInfoPtr_SelectOption_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006669 RID: 26217 RVA: 0x001D0FD4 File Offset: 0x001CF1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208829, XrefRangeEnd = 208835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyMaterial(MaterialFeature.NamedMaterial mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialFeature.NativeMethodInfoPtr_ApplyMaterial_Private_Void_NamedMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600666A RID: 26218 RVA: 0x001D1018 File Offset: 0x001CF218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208835, XrefRangeEnd = 208859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<FI_OptionList.Option> GetOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialFeature.NativeMethodInfoPtr_GetOptions_Protected_Virtual_List_1_Option_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FI_OptionList.Option>>(intPtr2) : null;
		}

		// Token: 0x0600666B RID: 26219 RVA: 0x001D1064 File Offset: 0x001CF264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208859, XrefRangeEnd = 208878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialFeature() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600666C RID: 26220 RVA: 0x001D10A0 File Offset: 0x001CF2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208878, XrefRangeEnd = 208879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialFeature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600666D RID: 26221 RVA: 0x001D10DC File Offset: 0x001CF2DC
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialFeature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600666E RID: 26222 RVA: 0x001D1118 File Offset: 0x001CF318
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialFeature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600666F RID: 26223 RVA: 0x001D1154 File Offset: 0x001CF354
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialFeature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006670 RID: 26224 RVA: 0x00030358 File Offset: 0x0002E558
		public MaterialFeature(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EAD RID: 7853
		// (get) Token: 0x06006671 RID: 26225 RVA: 0x001D1190 File Offset: 0x001CF390
		// (set) Token: 0x06006672 RID: 26226 RVA: 0x00030361 File Offset: 0x0002E561
		public unsafe List<MeshRenderer> materialTargets
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NativeFieldInfoPtr_materialTargets);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NativeFieldInfoPtr_materialTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EAE RID: 7854
		// (get) Token: 0x06006673 RID: 26227 RVA: 0x001D11C0 File Offset: 0x001CF3C0
		// (set) Token: 0x06006674 RID: 26228 RVA: 0x00030380 File Offset: 0x0002E580
		public unsafe List<MaterialFeature.NamedMaterial> materials
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NativeFieldInfoPtr_materials);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MaterialFeature.NamedMaterial>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NativeFieldInfoPtr_materials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EAF RID: 7855
		// (get) Token: 0x06006675 RID: 26229 RVA: 0x001D11F0 File Offset: 0x001CF3F0
		// (set) Token: 0x06006676 RID: 26230 RVA: 0x0003039F File Offset: 0x0002E59F
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001EB0 RID: 7856
		// (get) Token: 0x06006677 RID: 26231 RVA: 0x001D1218 File Offset: 0x001CF418
		// (set) Token: 0x06006678 RID: 26232 RVA: 0x000303BA File Offset: 0x0002E5BA
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040045E1 RID: 17889
		private static readonly System.IntPtr NativeFieldInfoPtr_materialTargets;

		// Token: 0x040045E2 RID: 17890
		private static readonly System.IntPtr NativeFieldInfoPtr_materials;

		// Token: 0x040045E3 RID: 17891
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040045E4 RID: 17892
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040045E5 RID: 17893
		private static readonly System.IntPtr NativeMethodInfoPtr_SelectOption_Public_Virtual_Void_Int32_0;

		// Token: 0x040045E6 RID: 17894
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyMaterial_Private_Void_NamedMaterial_0;

		// Token: 0x040045E7 RID: 17895
		private static readonly System.IntPtr NativeMethodInfoPtr_GetOptions_Protected_Virtual_List_1_Option_0;

		// Token: 0x040045E8 RID: 17896
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040045E9 RID: 17897
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040045EA RID: 17898
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040045EB RID: 17899
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040045EC RID: 17900
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000A7B RID: 2683
		[System.Serializable]
		public class NamedMaterial : Il2CppSystem.Object
		{
			// Token: 0x0600D48D RID: 54413 RVA: 0x00332EC0 File Offset: 0x003310C0
			// Note: this type is marked as 'beforefieldinit'.
			static NamedMaterial()
			{
				Il2CppClassPointerStore<MaterialFeature.NamedMaterial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, "NamedMaterial");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialFeature.NamedMaterial>.NativeClassPtr);
				MaterialFeature.NamedMaterial.NativeFieldInfoPtr_matName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFeature.NamedMaterial>.NativeClassPtr, "matName");
				MaterialFeature.NamedMaterial.NativeFieldInfoPtr_buttonColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFeature.NamedMaterial>.NativeClassPtr, "buttonColor");
				MaterialFeature.NamedMaterial.NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFeature.NamedMaterial>.NativeClassPtr, "mat");
				MaterialFeature.NamedMaterial.NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFeature.NamedMaterial>.NativeClassPtr, "price");
				MaterialFeature.NamedMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature.NamedMaterial>.NativeClassPtr, 100676369);
			}

			// Token: 0x0600D48E RID: 54414 RVA: 0x00332F50 File Offset: 0x00331150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208819, XrefRangeEnd = 208820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NamedMaterial() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialFeature.NamedMaterial>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialFeature.NamedMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D48F RID: 54415 RVA: 0x00067168 File Offset: 0x00065368
			public NamedMaterial(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041BE RID: 16830
			// (get) Token: 0x0600D490 RID: 54416 RVA: 0x00332F8C File Offset: 0x0033118C
			// (set) Token: 0x0600D491 RID: 54417 RVA: 0x00067171 File Offset: 0x00065371
			public unsafe string matName
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NamedMaterial.NativeFieldInfoPtr_matName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NamedMaterial.NativeFieldInfoPtr_matName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170041BF RID: 16831
			// (get) Token: 0x0600D492 RID: 54418 RVA: 0x00332FB4 File Offset: 0x003311B4
			// (set) Token: 0x0600D493 RID: 54419 RVA: 0x00067190 File Offset: 0x00065390
			public unsafe Color buttonColor
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NamedMaterial.NativeFieldInfoPtr_buttonColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NamedMaterial.NativeFieldInfoPtr_buttonColor)) = value;
				}
			}

			// Token: 0x170041C0 RID: 16832
			// (get) Token: 0x0600D494 RID: 54420 RVA: 0x00332FDC File Offset: 0x003311DC
			// (set) Token: 0x0600D495 RID: 54421 RVA: 0x000671AB File Offset: 0x000653AB
			public unsafe Material mat
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NamedMaterial.NativeFieldInfoPtr_mat);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NamedMaterial.NativeFieldInfoPtr_mat), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041C1 RID: 16833
			// (get) Token: 0x0600D496 RID: 54422 RVA: 0x0033300C File Offset: 0x0033120C
			// (set) Token: 0x0600D497 RID: 54423 RVA: 0x000671CA File Offset: 0x000653CA
			public unsafe float price
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NamedMaterial.NativeFieldInfoPtr_price);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NamedMaterial.NativeFieldInfoPtr_price)) = value;
				}
			}

			// Token: 0x04008F6C RID: 36716
			private static readonly System.IntPtr NativeFieldInfoPtr_matName;

			// Token: 0x04008F6D RID: 36717
			private static readonly System.IntPtr NativeFieldInfoPtr_buttonColor;

			// Token: 0x04008F6E RID: 36718
			private static readonly System.IntPtr NativeFieldInfoPtr_mat;

			// Token: 0x04008F6F RID: 36719
			private static readonly System.IntPtr NativeFieldInfoPtr_price;

			// Token: 0x04008F70 RID: 36720
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
