using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x0200079A RID: 1946
	public class TreeScaler : MonoBehaviour
	{
		// Token: 0x0600B898 RID: 47256 RVA: 0x002E1CB4 File Offset: 0x002DFEB4
		// Note: this type is marked as 'beforefieldinit'.
		static TreeScaler()
		{
			Il2CppClassPointerStore<TreeScaler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "TreeScaler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr);
			TreeScaler.NativeFieldInfoPtr_branchMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, "branchMeshes");
			TreeScaler.NativeFieldInfoPtr_minScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, "minScale");
			TreeScaler.NativeFieldInfoPtr_maxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, "maxScale");
			TreeScaler.NativeFieldInfoPtr_minScaleDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, "minScaleDistance");
			TreeScaler.NativeFieldInfoPtr_maxScaleDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, "maxScaleDistance");
			TreeScaler.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, 100686166);
			TreeScaler.NativeMethodInfoPtr_UpdateScale_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, 100686167);
			TreeScaler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, 100686168);
		}

		// Token: 0x0600B899 RID: 47257 RVA: 0x002E1D84 File Offset: 0x002DFF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315704, XrefRangeEnd = 315722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TreeScaler.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B89A RID: 47258 RVA: 0x002E1DC0 File Offset: 0x002DFFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315722, XrefRangeEnd = 315751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeScaler.NativeMethodInfoPtr_UpdateScale_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B89B RID: 47259 RVA: 0x002E1DF4 File Offset: 0x002DFFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315751, XrefRangeEnd = 315759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TreeScaler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeScaler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B89C RID: 47260 RVA: 0x0005A2C3 File Offset: 0x000584C3
		public TreeScaler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038EF RID: 14575
		// (get) Token: 0x0600B89D RID: 47261 RVA: 0x002E1E30 File Offset: 0x002E0030
		// (set) Token: 0x0600B89E RID: 47262 RVA: 0x0005A2CC File Offset: 0x000584CC
		public unsafe List<Transform> branchMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_branchMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_branchMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038F0 RID: 14576
		// (get) Token: 0x0600B89F RID: 47263 RVA: 0x002E1E60 File Offset: 0x002E0060
		// (set) Token: 0x0600B8A0 RID: 47264 RVA: 0x0005A2EB File Offset: 0x000584EB
		public unsafe float minScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_minScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_minScale)) = value;
			}
		}

		// Token: 0x170038F1 RID: 14577
		// (get) Token: 0x0600B8A1 RID: 47265 RVA: 0x002E1E88 File Offset: 0x002E0088
		// (set) Token: 0x0600B8A2 RID: 47266 RVA: 0x0005A306 File Offset: 0x00058506
		public unsafe float maxScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_maxScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_maxScale)) = value;
			}
		}

		// Token: 0x170038F2 RID: 14578
		// (get) Token: 0x0600B8A3 RID: 47267 RVA: 0x002E1EB0 File Offset: 0x002E00B0
		// (set) Token: 0x0600B8A4 RID: 47268 RVA: 0x0005A321 File Offset: 0x00058521
		public unsafe float minScaleDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_minScaleDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_minScaleDistance)) = value;
			}
		}

		// Token: 0x170038F3 RID: 14579
		// (get) Token: 0x0600B8A5 RID: 47269 RVA: 0x002E1ED8 File Offset: 0x002E00D8
		// (set) Token: 0x0600B8A6 RID: 47270 RVA: 0x0005A33C File Offset: 0x0005853C
		public unsafe float maxScaleDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_maxScaleDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_maxScaleDistance)) = value;
			}
		}

		// Token: 0x04007C92 RID: 31890
		private static readonly IntPtr NativeFieldInfoPtr_branchMeshes;

		// Token: 0x04007C93 RID: 31891
		private static readonly IntPtr NativeFieldInfoPtr_minScale;

		// Token: 0x04007C94 RID: 31892
		private static readonly IntPtr NativeFieldInfoPtr_maxScale;

		// Token: 0x04007C95 RID: 31893
		private static readonly IntPtr NativeFieldInfoPtr_minScaleDistance;

		// Token: 0x04007C96 RID: 31894
		private static readonly IntPtr NativeFieldInfoPtr_maxScaleDistance;

		// Token: 0x04007C97 RID: 31895
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04007C98 RID: 31896
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScale_Private_Void_0;

		// Token: 0x04007C99 RID: 31897
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
