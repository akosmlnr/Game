using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Construction.Features;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.Features
{
	// Token: 0x020004A5 RID: 1189
	public class Feature : NetworkBehaviour
	{
		// Token: 0x06006624 RID: 26148 RVA: 0x001D0194 File Offset: 0x001CE394
		// Note: this type is marked as 'beforefieldinit'.
		static Feature()
		{
			Il2CppClassPointerStore<Feature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.Features", "Feature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Feature>.NativeClassPtr);
			Feature.NativeFieldInfoPtr_featureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Feature>.NativeClassPtr, "featureName");
			Feature.NativeFieldInfoPtr_featureIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Feature>.NativeClassPtr, "featureIcon");
			Feature.NativeFieldInfoPtr_featureIconLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Feature>.NativeClassPtr, "featureIconLocation");
			Feature.NativeFieldInfoPtr_featureInterfacePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Feature>.NativeClassPtr, "featureInterfacePrefab");
			Feature.NativeFieldInfoPtr_disableRoofDisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Feature>.NativeClassPtr, "disableRoofDisibility");
			Feature.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Feature>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Construction.Features.FeatureAssembly-CSharp.dll_Excuted");
			Feature.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Feature>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Construction.Features.FeatureAssembly-CSharp.dll_Excuted");
			Feature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100676338);
			Feature.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100676339);
			Feature.NativeMethodInfoPtr_CreateInterface_Public_Virtual_New_FI_Base_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100676340);
			Feature.NativeMethodInfoPtr_Default_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100676341);
			Feature.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100676342);
			Feature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100676343);
			Feature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100676344);
			Feature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100676345);
			Feature.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100676346);
		}

		// Token: 0x06006625 RID: 26149 RVA: 0x001D0304 File Offset: 0x001CE504
		[CallerCount(0)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Feature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006626 RID: 26150 RVA: 0x001D0340 File Offset: 0x001CE540
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Feature.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006627 RID: 26151 RVA: 0x001D037C File Offset: 0x001CE57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208726, XrefRangeEnd = 208735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual FI_Base CreateInterface(Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Feature.NativeMethodInfoPtr_CreateInterface_Public_Virtual_New_FI_Base_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<FI_Base>(intPtr2) : null;
		}

		// Token: 0x06006628 RID: 26152 RVA: 0x001D03D8 File Offset: 0x001CE5D8
		[CallerCount(0)]
		public unsafe virtual void Default()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Feature.NativeMethodInfoPtr_Default_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006629 RID: 26153 RVA: 0x001D0414 File Offset: 0x001CE614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208735, XrefRangeEnd = 208740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Feature() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Feature>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Feature.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600662A RID: 26154 RVA: 0x001D0450 File Offset: 0x001CE650
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Feature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600662B RID: 26155 RVA: 0x001D048C File Offset: 0x001CE68C
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Feature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600662C RID: 26156 RVA: 0x001D04C8 File Offset: 0x001CE6C8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Feature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600662D RID: 26157 RVA: 0x001D0504 File Offset: 0x001CE704
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Feature.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600662E RID: 26158 RVA: 0x0003010C File Offset: 0x0002E30C
		public Feature(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E9A RID: 7834
		// (get) Token: 0x0600662F RID: 26159 RVA: 0x001D0540 File Offset: 0x001CE740
		// (set) Token: 0x06006630 RID: 26160 RVA: 0x00030115 File Offset: 0x0002E315
		public unsafe string featureName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_featureName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_featureName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001E9B RID: 7835
		// (get) Token: 0x06006631 RID: 26161 RVA: 0x001D0568 File Offset: 0x001CE768
		// (set) Token: 0x06006632 RID: 26162 RVA: 0x00030134 File Offset: 0x0002E334
		public unsafe Sprite featureIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_featureIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_featureIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E9C RID: 7836
		// (get) Token: 0x06006633 RID: 26163 RVA: 0x001D0598 File Offset: 0x001CE798
		// (set) Token: 0x06006634 RID: 26164 RVA: 0x00030153 File Offset: 0x0002E353
		public unsafe Transform featureIconLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_featureIconLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_featureIconLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E9D RID: 7837
		// (get) Token: 0x06006635 RID: 26165 RVA: 0x001D05C8 File Offset: 0x001CE7C8
		// (set) Token: 0x06006636 RID: 26166 RVA: 0x00030172 File Offset: 0x0002E372
		public unsafe GameObject featureInterfacePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_featureInterfacePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_featureInterfacePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E9E RID: 7838
		// (get) Token: 0x06006637 RID: 26167 RVA: 0x001D05F8 File Offset: 0x001CE7F8
		// (set) Token: 0x06006638 RID: 26168 RVA: 0x00030191 File Offset: 0x0002E391
		public unsafe bool disableRoofDisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_disableRoofDisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_disableRoofDisibility)) = value;
			}
		}

		// Token: 0x17001E9F RID: 7839
		// (get) Token: 0x06006639 RID: 26169 RVA: 0x001D0620 File Offset: 0x001CE820
		// (set) Token: 0x0600663A RID: 26170 RVA: 0x000301AC File Offset: 0x0002E3AC
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001EA0 RID: 7840
		// (get) Token: 0x0600663B RID: 26171 RVA: 0x001D0648 File Offset: 0x001CE848
		// (set) Token: 0x0600663C RID: 26172 RVA: 0x000301C7 File Offset: 0x0002E3C7
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040045B7 RID: 17847
		private static readonly IntPtr NativeFieldInfoPtr_featureName;

		// Token: 0x040045B8 RID: 17848
		private static readonly IntPtr NativeFieldInfoPtr_featureIcon;

		// Token: 0x040045B9 RID: 17849
		private static readonly IntPtr NativeFieldInfoPtr_featureIconLocation;

		// Token: 0x040045BA RID: 17850
		private static readonly IntPtr NativeFieldInfoPtr_featureInterfacePrefab;

		// Token: 0x040045BB RID: 17851
		private static readonly IntPtr NativeFieldInfoPtr_disableRoofDisibility;

		// Token: 0x040045BC RID: 17852
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040045BD RID: 17853
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040045BE RID: 17854
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040045BF RID: 17855
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x040045C0 RID: 17856
		private static readonly IntPtr NativeMethodInfoPtr_CreateInterface_Public_Virtual_New_FI_Base_Transform_0;

		// Token: 0x040045C1 RID: 17857
		private static readonly IntPtr NativeMethodInfoPtr_Default_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040045C2 RID: 17858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040045C3 RID: 17859
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040045C4 RID: 17860
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040045C5 RID: 17861
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040045C6 RID: 17862
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
