using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004E3 RID: 1251
	public class BuildUpdate_Surface : BuildUpdate_Base
	{
		// Token: 0x06006C95 RID: 27797 RVA: 0x001E6A2C File Offset: 0x001E4C2C
		// Note: this type is marked as 'beforefieldinit'.
		static BuildUpdate_Surface()
		{
			Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildUpdate_Surface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr);
			BuildUpdate_Surface.NativeFieldInfoPtr_GhostModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "GhostModel");
			BuildUpdate_Surface.NativeFieldInfoPtr_BuildableItemClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "BuildableItemClass");
			BuildUpdate_Surface.NativeFieldInfoPtr_ItemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "ItemInstance");
			BuildUpdate_Surface.NativeFieldInfoPtr_CurrentRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "CurrentRotation");
			BuildUpdate_Surface.NativeFieldInfoPtr_DetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "DetectionMask");
			BuildUpdate_Surface.NativeFieldInfoPtr_validPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "validPosition");
			BuildUpdate_Surface.NativeFieldInfoPtr_currentGhostMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "currentGhostMaterial");
			BuildUpdate_Surface.NativeFieldInfoPtr_hoveredValidSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "hoveredValidSurface");
			BuildUpdate_Surface.NativeMethodInfoPtr_get_detectionRange_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100677160);
			BuildUpdate_Surface.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100677161);
			BuildUpdate_Surface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100677162);
			BuildUpdate_Surface.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100677163);
			BuildUpdate_Surface.NativeMethodInfoPtr_PositionObjectInFrontOfPlayer_Protected_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100677164);
			BuildUpdate_Surface.NativeMethodInfoPtr_IsSurfaceValidForItem_Private_Boolean_Surface_Collider_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100677165);
			BuildUpdate_Surface.NativeMethodInfoPtr_CheckRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100677166);
			BuildUpdate_Surface.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100677167);
			BuildUpdate_Surface.NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100677168);
			BuildUpdate_Surface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100677169);
		}

		// Token: 0x1700206C RID: 8300
		// (get) Token: 0x06006C96 RID: 27798 RVA: 0x001E6BC4 File Offset: 0x001E4DC4
		public unsafe float detectionRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Surface.NativeMethodInfoPtr_get_detectionRange_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06006C97 RID: 27799 RVA: 0x001E6C00 File Offset: 0x001E4E00
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 40160, RefRangeEnd = 40167, XrefRangeStart = 40160, XrefRangeEnd = 40167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Surface.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C98 RID: 27800 RVA: 0x001E6C3C File Offset: 0x001E4E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219240, XrefRangeEnd = 219258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Surface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C99 RID: 27801 RVA: 0x001E6C78 File Offset: 0x001E4E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219258, XrefRangeEnd = 219350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Surface.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C9A RID: 27802 RVA: 0x001E6CB4 File Offset: 0x001E4EB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219410, RefRangeEnd = 219411, XrefRangeStart = 219350, XrefRangeEnd = 219410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PositionObjectInFrontOfPlayer(float dist, bool sanitizeForward)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dist;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sanitizeForward;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Surface.NativeMethodInfoPtr_PositionObjectInFrontOfPlayer_Protected_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C9B RID: 27803 RVA: 0x001E6D00 File Offset: 0x001E4F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219411, XrefRangeEnd = 219423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSurfaceValidForItem(Surface surface, Collider hitCollider, Vector3 hitPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(surface);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hitCollider);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitPoint;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Surface.NativeMethodInfoPtr_IsSurfaceValidForItem_Private_Boolean_Surface_Collider_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006C9C RID: 27804 RVA: 0x001E6D70 File Offset: 0x001E4F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219423, XrefRangeEnd = 219436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Surface.NativeMethodInfoPtr_CheckRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C9D RID: 27805 RVA: 0x001E6DA4 File Offset: 0x001E4FA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219452, RefRangeEnd = 219453, XrefRangeStart = 219436, XrefRangeEnd = 219452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Surface.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C9E RID: 27806 RVA: 0x001E6DD8 File Offset: 0x001E4FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219453, XrefRangeEnd = 219488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Place()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Surface.NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C9F RID: 27807 RVA: 0x001E6E14 File Offset: 0x001E5014
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 20792, RefRangeEnd = 20806, XrefRangeStart = 20792, XrefRangeEnd = 20806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildUpdate_Surface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Surface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006CA0 RID: 27808 RVA: 0x00033171 File Offset: 0x00031371
		public BuildUpdate_Surface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002064 RID: 8292
		// (get) Token: 0x06006CA1 RID: 27809 RVA: 0x001E6E50 File Offset: 0x001E5050
		// (set) Token: 0x06006CA2 RID: 27810 RVA: 0x0003317A File Offset: 0x0003137A
		public unsafe GameObject GhostModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_GhostModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_GhostModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002065 RID: 8293
		// (get) Token: 0x06006CA3 RID: 27811 RVA: 0x001E6E80 File Offset: 0x001E5080
		// (set) Token: 0x06006CA4 RID: 27812 RVA: 0x00033199 File Offset: 0x00031399
		public unsafe SurfaceItem BuildableItemClass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_BuildableItemClass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SurfaceItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_BuildableItemClass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002066 RID: 8294
		// (get) Token: 0x06006CA5 RID: 27813 RVA: 0x001E6EB0 File Offset: 0x001E50B0
		// (set) Token: 0x06006CA6 RID: 27814 RVA: 0x000331B8 File Offset: 0x000313B8
		public unsafe ItemInstance ItemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_ItemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_ItemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002067 RID: 8295
		// (get) Token: 0x06006CA7 RID: 27815 RVA: 0x001E6EE0 File Offset: 0x001E50E0
		// (set) Token: 0x06006CA8 RID: 27816 RVA: 0x000331D7 File Offset: 0x000313D7
		public unsafe float CurrentRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_CurrentRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_CurrentRotation)) = value;
			}
		}

		// Token: 0x17002068 RID: 8296
		// (get) Token: 0x06006CA9 RID: 27817 RVA: 0x001E6F08 File Offset: 0x001E5108
		// (set) Token: 0x06006CAA RID: 27818 RVA: 0x000331F2 File Offset: 0x000313F2
		public unsafe LayerMask DetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_DetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_DetectionMask)) = value;
			}
		}

		// Token: 0x17002069 RID: 8297
		// (get) Token: 0x06006CAB RID: 27819 RVA: 0x001E6F30 File Offset: 0x001E5130
		// (set) Token: 0x06006CAC RID: 27820 RVA: 0x0003320D File Offset: 0x0003140D
		public unsafe bool validPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_validPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_validPosition)) = value;
			}
		}

		// Token: 0x1700206A RID: 8298
		// (get) Token: 0x06006CAD RID: 27821 RVA: 0x001E6F58 File Offset: 0x001E5158
		// (set) Token: 0x06006CAE RID: 27822 RVA: 0x00033228 File Offset: 0x00031428
		public unsafe Material currentGhostMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_currentGhostMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_currentGhostMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700206B RID: 8299
		// (get) Token: 0x06006CAF RID: 27823 RVA: 0x001E6F88 File Offset: 0x001E5188
		// (set) Token: 0x06006CB0 RID: 27824 RVA: 0x00033247 File Offset: 0x00031447
		public unsafe Surface hoveredValidSurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_hoveredValidSurface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Surface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_hoveredValidSurface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004A54 RID: 19028
		private static readonly IntPtr NativeFieldInfoPtr_GhostModel;

		// Token: 0x04004A55 RID: 19029
		private static readonly IntPtr NativeFieldInfoPtr_BuildableItemClass;

		// Token: 0x04004A56 RID: 19030
		private static readonly IntPtr NativeFieldInfoPtr_ItemInstance;

		// Token: 0x04004A57 RID: 19031
		private static readonly IntPtr NativeFieldInfoPtr_CurrentRotation;

		// Token: 0x04004A58 RID: 19032
		private static readonly IntPtr NativeFieldInfoPtr_DetectionMask;

		// Token: 0x04004A59 RID: 19033
		private static readonly IntPtr NativeFieldInfoPtr_validPosition;

		// Token: 0x04004A5A RID: 19034
		private static readonly IntPtr NativeFieldInfoPtr_currentGhostMaterial;

		// Token: 0x04004A5B RID: 19035
		private static readonly IntPtr NativeFieldInfoPtr_hoveredValidSurface;

		// Token: 0x04004A5C RID: 19036
		private static readonly IntPtr NativeMethodInfoPtr_get_detectionRange_Private_get_Single_0;

		// Token: 0x04004A5D RID: 19037
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04004A5E RID: 19038
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04004A5F RID: 19039
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004A60 RID: 19040
		private static readonly IntPtr NativeMethodInfoPtr_PositionObjectInFrontOfPlayer_Protected_Void_Single_Boolean_0;

		// Token: 0x04004A61 RID: 19041
		private static readonly IntPtr NativeMethodInfoPtr_IsSurfaceValidForItem_Private_Boolean_Surface_Collider_Vector3_0;

		// Token: 0x04004A62 RID: 19042
		private static readonly IntPtr NativeMethodInfoPtr_CheckRotation_Protected_Void_0;

		// Token: 0x04004A63 RID: 19043
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0;

		// Token: 0x04004A64 RID: 19044
		private static readonly IntPtr NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0;

		// Token: 0x04004A65 RID: 19045
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
