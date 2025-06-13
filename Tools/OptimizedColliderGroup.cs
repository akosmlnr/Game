using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000565 RID: 1381
	public class OptimizedColliderGroup : MonoBehaviour
	{
		// Token: 0x06007950 RID: 31056 RVA: 0x0021066C File Offset: 0x0020E86C
		// Note: this type is marked as 'beforefieldinit'.
		static OptimizedColliderGroup()
		{
			Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "OptimizedColliderGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr);
			OptimizedColliderGroup.NativeFieldInfoPtr_UPDATE_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, "UPDATE_DISTANCE");
			OptimizedColliderGroup.NativeFieldInfoPtr_Colliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, "Colliders");
			OptimizedColliderGroup.NativeFieldInfoPtr_ColliderEnableMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, "ColliderEnableMaxDistance");
			OptimizedColliderGroup.NativeFieldInfoPtr_sqrColliderEnableMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, "sqrColliderEnableMaxDistance");
			OptimizedColliderGroup.NativeFieldInfoPtr_collidersEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, "collidersEnabled");
			OptimizedColliderGroup.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678673);
			OptimizedColliderGroup.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678674);
			OptimizedColliderGroup.NativeMethodInfoPtr_RegisterEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678675);
			OptimizedColliderGroup.NativeMethodInfoPtr_GetColliders_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678676);
			OptimizedColliderGroup.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678677);
			OptimizedColliderGroup.NativeMethodInfoPtr_Refresh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678678);
			OptimizedColliderGroup.NativeMethodInfoPtr_SetCollidersEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678679);
			OptimizedColliderGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678680);
		}

		// Token: 0x06007951 RID: 31057 RVA: 0x002107A0 File Offset: 0x0020E9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235291, XrefRangeEnd = 235315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007952 RID: 31058 RVA: 0x002107D4 File Offset: 0x0020E9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235315, XrefRangeEnd = 235329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007953 RID: 31059 RVA: 0x00210808 File Offset: 0x0020EA08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 235360, RefRangeEnd = 235361, XrefRangeStart = 235329, XrefRangeEnd = 235360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_RegisterEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007954 RID: 31060 RVA: 0x0021083C File Offset: 0x0020EA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235361, XrefRangeEnd = 235365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetColliders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_GetColliders_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007955 RID: 31061 RVA: 0x00210870 File Offset: 0x0020EA70
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007956 RID: 31062 RVA: 0x002108A4 File Offset: 0x0020EAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235365, XrefRangeEnd = 235391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_Refresh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007957 RID: 31063 RVA: 0x002108D8 File Offset: 0x0020EAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235391, XrefRangeEnd = 235397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCollidersEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_SetCollidersEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007958 RID: 31064 RVA: 0x00210918 File Offset: 0x0020EB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235397, XrefRangeEnd = 235398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptimizedColliderGroup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007959 RID: 31065 RVA: 0x00039388 File Offset: 0x00037588
		public OptimizedColliderGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700247D RID: 9341
		// (get) Token: 0x0600795A RID: 31066 RVA: 0x00210954 File Offset: 0x0020EB54
		// (set) Token: 0x0600795B RID: 31067 RVA: 0x00039391 File Offset: 0x00037591
		public unsafe static int UPDATE_DISTANCE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(OptimizedColliderGroup.NativeFieldInfoPtr_UPDATE_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OptimizedColliderGroup.NativeFieldInfoPtr_UPDATE_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x1700247E RID: 9342
		// (get) Token: 0x0600795C RID: 31068 RVA: 0x00210970 File Offset: 0x0020EB70
		// (set) Token: 0x0600795D RID: 31069 RVA: 0x0003939F File Offset: 0x0003759F
		public unsafe Il2CppReferenceArray<Collider> Colliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_Colliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_Colliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700247F RID: 9343
		// (get) Token: 0x0600795E RID: 31070 RVA: 0x002109A0 File Offset: 0x0020EBA0
		// (set) Token: 0x0600795F RID: 31071 RVA: 0x000393BE File Offset: 0x000375BE
		public unsafe float ColliderEnableMaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_ColliderEnableMaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_ColliderEnableMaxDistance)) = value;
			}
		}

		// Token: 0x17002480 RID: 9344
		// (get) Token: 0x06007960 RID: 31072 RVA: 0x002109C8 File Offset: 0x0020EBC8
		// (set) Token: 0x06007961 RID: 31073 RVA: 0x000393D9 File Offset: 0x000375D9
		public unsafe float sqrColliderEnableMaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_sqrColliderEnableMaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_sqrColliderEnableMaxDistance)) = value;
			}
		}

		// Token: 0x17002481 RID: 9345
		// (get) Token: 0x06007962 RID: 31074 RVA: 0x002109F0 File Offset: 0x0020EBF0
		// (set) Token: 0x06007963 RID: 31075 RVA: 0x000393F4 File Offset: 0x000375F4
		public unsafe bool collidersEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_collidersEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_collidersEnabled)) = value;
			}
		}

		// Token: 0x040052CF RID: 21199
		private static readonly IntPtr NativeFieldInfoPtr_UPDATE_DISTANCE;

		// Token: 0x040052D0 RID: 21200
		private static readonly IntPtr NativeFieldInfoPtr_Colliders;

		// Token: 0x040052D1 RID: 21201
		private static readonly IntPtr NativeFieldInfoPtr_ColliderEnableMaxDistance;

		// Token: 0x040052D2 RID: 21202
		private static readonly IntPtr NativeFieldInfoPtr_sqrColliderEnableMaxDistance;

		// Token: 0x040052D3 RID: 21203
		private static readonly IntPtr NativeFieldInfoPtr_collidersEnabled;

		// Token: 0x040052D4 RID: 21204
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040052D5 RID: 21205
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040052D6 RID: 21206
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEvent_Private_Void_0;

		// Token: 0x040052D7 RID: 21207
		private static readonly IntPtr NativeMethodInfoPtr_GetColliders_Public_Void_0;

		// Token: 0x040052D8 RID: 21208
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040052D9 RID: 21209
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_0;

		// Token: 0x040052DA RID: 21210
		private static readonly IntPtr NativeMethodInfoPtr_SetCollidersEnabled_Private_Void_Boolean_0;

		// Token: 0x040052DB RID: 21211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
