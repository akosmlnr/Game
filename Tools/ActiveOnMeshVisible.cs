using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200054E RID: 1358
	public class ActiveOnMeshVisible : MonoBehaviour
	{
		// Token: 0x06007850 RID: 30800 RVA: 0x0020D6CC File Offset: 0x0020B8CC
		// Note: this type is marked as 'beforefieldinit'.
		static ActiveOnMeshVisible()
		{
			Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ActiveOnMeshVisible");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr);
			ActiveOnMeshVisible.NativeFieldInfoPtr_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr, "Mesh");
			ActiveOnMeshVisible.NativeFieldInfoPtr_ObjectsToActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr, "ObjectsToActivate");
			ActiveOnMeshVisible.NativeFieldInfoPtr_Reverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr, "Reverse");
			ActiveOnMeshVisible.NativeFieldInfoPtr_isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr, "isVisible");
			ActiveOnMeshVisible.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr, 100678546);
			ActiveOnMeshVisible.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr, 100678547);
		}

		// Token: 0x06007851 RID: 30801 RVA: 0x0020D774 File Offset: 0x0020B974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234471, XrefRangeEnd = 234477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveOnMeshVisible.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007852 RID: 30802 RVA: 0x0020D7A8 File Offset: 0x0020B9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234477, XrefRangeEnd = 234478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActiveOnMeshVisible() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveOnMeshVisible.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007853 RID: 30803 RVA: 0x00038C55 File Offset: 0x00036E55
		public ActiveOnMeshVisible(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700243C RID: 9276
		// (get) Token: 0x06007854 RID: 30804 RVA: 0x0020D7E4 File Offset: 0x0020B9E4
		// (set) Token: 0x06007855 RID: 30805 RVA: 0x00038C5E File Offset: 0x00036E5E
		public unsafe MeshRenderer Mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_Mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_Mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700243D RID: 9277
		// (get) Token: 0x06007856 RID: 30806 RVA: 0x0020D814 File Offset: 0x0020BA14
		// (set) Token: 0x06007857 RID: 30807 RVA: 0x00038C7D File Offset: 0x00036E7D
		public unsafe Il2CppReferenceArray<GameObject> ObjectsToActivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_ObjectsToActivate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_ObjectsToActivate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700243E RID: 9278
		// (get) Token: 0x06007858 RID: 30808 RVA: 0x0020D844 File Offset: 0x0020BA44
		// (set) Token: 0x06007859 RID: 30809 RVA: 0x00038C9C File Offset: 0x00036E9C
		public unsafe bool Reverse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_Reverse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_Reverse)) = value;
			}
		}

		// Token: 0x1700243F RID: 9279
		// (get) Token: 0x0600785A RID: 30810 RVA: 0x0020D86C File Offset: 0x0020BA6C
		// (set) Token: 0x0600785B RID: 30811 RVA: 0x00038CB7 File Offset: 0x00036EB7
		public unsafe bool isVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_isVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_isVisible)) = value;
			}
		}

		// Token: 0x04005237 RID: 21047
		private static readonly IntPtr NativeFieldInfoPtr_Mesh;

		// Token: 0x04005238 RID: 21048
		private static readonly IntPtr NativeFieldInfoPtr_ObjectsToActivate;

		// Token: 0x04005239 RID: 21049
		private static readonly IntPtr NativeFieldInfoPtr_Reverse;

		// Token: 0x0400523A RID: 21050
		private static readonly IntPtr NativeFieldInfoPtr_isVisible;

		// Token: 0x0400523B RID: 21051
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400523C RID: 21052
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
