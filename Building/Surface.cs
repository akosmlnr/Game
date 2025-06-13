using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004E6 RID: 1254
	public class Surface : MonoBehaviour
	{
		// Token: 0x06006CBF RID: 27839 RVA: 0x001E7210 File Offset: 0x001E5410
		// Note: this type is marked as 'beforefieldinit'.
		static Surface()
		{
			Il2CppClassPointerStore<Surface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "Surface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Surface>.NativeClassPtr);
			Surface.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Surface>.NativeClassPtr, "<GUID>k__BackingField");
			Surface.NativeFieldInfoPtr_SurfaceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Surface>.NativeClassPtr, "SurfaceType");
			Surface.NativeFieldInfoPtr_ValidFaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Surface>.NativeClassPtr, "ValidFaces");
			Surface.NativeFieldInfoPtr_ParentProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Surface>.NativeClassPtr, "ParentProperty");
			Surface.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Surface>.NativeClassPtr, "BakedGUID");
			Surface.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100677174);
			Surface.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100677175);
			Surface.NativeMethodInfoPtr_get_Container_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100677176);
			Surface.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100677177);
			Surface.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100677178);
			Surface.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100677179);
			Surface.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100677180);
			Surface.NativeMethodInfoPtr_GetRelativePosition_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100677181);
			Surface.NativeMethodInfoPtr_GetRelativeRotation_Public_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100677182);
			Surface.NativeMethodInfoPtr_IsFrontFace_Public_Boolean_Vector3_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100677183);
			Surface.NativeMethodInfoPtr_IsPointValid_Public_Boolean_Vector3_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100677184);
			Surface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100677185);
		}

		// Token: 0x17002075 RID: 8309
		// (get) Token: 0x06006CC0 RID: 27840 RVA: 0x001E7394 File Offset: 0x001E5594
		// (set) Token: 0x06006CC1 RID: 27841 RVA: 0x001E73D0 File Offset: 0x001E55D0
		public unsafe virtual Il2CppSystem.Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002076 RID: 8310
		// (get) Token: 0x06006CC2 RID: 27842 RVA: 0x001E7410 File Offset: 0x001E5610
		public unsafe Transform Container
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219523, XrefRangeEnd = 219525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_get_Container_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x06006CC3 RID: 27843 RVA: 0x001E7450 File Offset: 0x001E5650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219525, XrefRangeEnd = 219528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006CC4 RID: 27844 RVA: 0x001E7484 File Offset: 0x001E5684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219528, XrefRangeEnd = 219540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006CC5 RID: 27845 RVA: 0x001E74B8 File Offset: 0x001E56B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219540, XrefRangeEnd = 219569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Surface.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006CC6 RID: 27846 RVA: 0x001E74F4 File Offset: 0x001E56F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219569, XrefRangeEnd = 219573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Il2CppSystem.Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006CC7 RID: 27847 RVA: 0x001E7534 File Offset: 0x001E5734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219573, XrefRangeEnd = 219575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetRelativePosition(Vector3 worldPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref worldPosition;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_GetRelativePosition_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006CC8 RID: 27848 RVA: 0x001E7580 File Offset: 0x001E5780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219578, RefRangeEnd = 219579, XrefRangeStart = 219575, XrefRangeEnd = 219578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quaternion GetRelativeRotation(Quaternion worldRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref worldRotation;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_GetRelativeRotation_Public_Quaternion_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006CC9 RID: 27849 RVA: 0x001E75CC File Offset: 0x001E57CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219579, XrefRangeEnd = 219581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsFrontFace(Vector3 point, Collider collider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collider);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_IsFrontFace_Public_Boolean_Vector3_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006CCA RID: 27850 RVA: 0x001E7628 File Offset: 0x001E5828
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219618, RefRangeEnd = 219620, XrefRangeStart = 219581, XrefRangeEnd = 219618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointValid(Vector3 point, Collider hitCollider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hitCollider);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_IsPointValid_Public_Boolean_Vector3_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006CCB RID: 27851 RVA: 0x001E7684 File Offset: 0x001E5884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219620, XrefRangeEnd = 219637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Surface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Surface>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006CCC RID: 27852 RVA: 0x00033306 File Offset: 0x00031506
		public Surface(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002070 RID: 8304
		// (get) Token: 0x06006CCD RID: 27853 RVA: 0x001E76C0 File Offset: 0x001E58C0
		// (set) Token: 0x06006CCE RID: 27854 RVA: 0x0003330F File Offset: 0x0003150F
		public unsafe Il2CppSystem.Guid _GUID_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17002071 RID: 8305
		// (get) Token: 0x06006CCF RID: 27855 RVA: 0x001E76E8 File Offset: 0x001E58E8
		// (set) Token: 0x06006CD0 RID: 27856 RVA: 0x0003332A File Offset: 0x0003152A
		public unsafe Surface.ESurfaceType SurfaceType
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_SurfaceType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_SurfaceType)) = value;
			}
		}

		// Token: 0x17002072 RID: 8306
		// (get) Token: 0x06006CD1 RID: 27857 RVA: 0x001E7710 File Offset: 0x001E5910
		// (set) Token: 0x06006CD2 RID: 27858 RVA: 0x00033345 File Offset: 0x00031545
		public unsafe List<Surface.EFace> ValidFaces
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_ValidFaces);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Surface.EFace>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_ValidFaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002073 RID: 8307
		// (get) Token: 0x06006CD3 RID: 27859 RVA: 0x001E7740 File Offset: 0x001E5940
		// (set) Token: 0x06006CD4 RID: 27860 RVA: 0x00033364 File Offset: 0x00031564
		public unsafe Property ParentProperty
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_ParentProperty);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_ParentProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002074 RID: 8308
		// (get) Token: 0x06006CD5 RID: 27861 RVA: 0x001E7770 File Offset: 0x001E5970
		// (set) Token: 0x06006CD6 RID: 27862 RVA: 0x00033383 File Offset: 0x00031583
		public unsafe string BakedGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004A6D RID: 19053
		private static readonly System.IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04004A6E RID: 19054
		private static readonly System.IntPtr NativeFieldInfoPtr_SurfaceType;

		// Token: 0x04004A6F RID: 19055
		private static readonly System.IntPtr NativeFieldInfoPtr_ValidFaces;

		// Token: 0x04004A70 RID: 19056
		private static readonly System.IntPtr NativeFieldInfoPtr_ParentProperty;

		// Token: 0x04004A71 RID: 19057
		private static readonly System.IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04004A72 RID: 19058
		private static readonly System.IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04004A73 RID: 19059
		private static readonly System.IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04004A74 RID: 19060
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Container_Public_get_Transform_0;

		// Token: 0x04004A75 RID: 19061
		private static readonly System.IntPtr NativeMethodInfoPtr_RegenerateGUID_Public_Void_0;

		// Token: 0x04004A76 RID: 19062
		private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04004A77 RID: 19063
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004A78 RID: 19064
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04004A79 RID: 19065
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRelativePosition_Public_Vector3_Vector3_0;

		// Token: 0x04004A7A RID: 19066
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRelativeRotation_Public_Quaternion_Quaternion_0;

		// Token: 0x04004A7B RID: 19067
		private static readonly System.IntPtr NativeMethodInfoPtr_IsFrontFace_Public_Boolean_Vector3_Collider_0;

		// Token: 0x04004A7C RID: 19068
		private static readonly System.IntPtr NativeMethodInfoPtr_IsPointValid_Public_Boolean_Vector3_Collider_0;

		// Token: 0x04004A7D RID: 19069
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AA3 RID: 2723
		[OriginalName("Assembly-CSharp.dll", "", "ESurfaceType")]
		public enum ESurfaceType
		{
			// Token: 0x04009027 RID: 36903
			Wall,
			// Token: 0x04009028 RID: 36904
			Roof
		}

		// Token: 0x02000AA4 RID: 2724
		[OriginalName("Assembly-CSharp.dll", "", "EFace")]
		public enum EFace
		{
			// Token: 0x0400902A RID: 36906
			Front,
			// Token: 0x0400902B RID: 36907
			Back,
			// Token: 0x0400902C RID: 36908
			Top,
			// Token: 0x0400902D RID: 36909
			Bottom,
			// Token: 0x0400902E RID: 36910
			Left,
			// Token: 0x0400902F RID: 36911
			Right
		}
	}
}
