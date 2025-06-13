using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x02000547 RID: 1351
	public class TrashRemovalVolume : MonoBehaviour
	{
		// Token: 0x060077DB RID: 30683 RVA: 0x0020C1D8 File Offset: 0x0020A3D8
		// Note: this type is marked as 'beforefieldinit'.
		static TrashRemovalVolume()
		{
			Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashRemovalVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr);
			TrashRemovalVolume.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, "Collider");
			TrashRemovalVolume.NativeFieldInfoPtr_RemovalChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, "RemovalChance");
			TrashRemovalVolume.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, 100678499);
			TrashRemovalVolume.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, 100678500);
			TrashRemovalVolume.NativeMethodInfoPtr_SleepStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, 100678501);
			TrashRemovalVolume.NativeMethodInfoPtr_GetTrash_Private_Il2CppReferenceArray_1_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, 100678502);
			TrashRemovalVolume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, 100678503);
		}

		// Token: 0x060077DC RID: 30684 RVA: 0x0020C294 File Offset: 0x0020A494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233828, XrefRangeEnd = 233840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashRemovalVolume.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060077DD RID: 30685 RVA: 0x0020C2C8 File Offset: 0x0020A4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233840, XrefRangeEnd = 233854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashRemovalVolume.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060077DE RID: 30686 RVA: 0x0020C2FC File Offset: 0x0020A4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233854, XrefRangeEnd = 233859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashRemovalVolume.NativeMethodInfoPtr_SleepStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060077DF RID: 30687 RVA: 0x0020C330 File Offset: 0x0020A530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233896, RefRangeEnd = 233897, XrefRangeStart = 233859, XrefRangeEnd = 233896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<TrashItem> GetTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashRemovalVolume.NativeMethodInfoPtr_GetTrash_Private_Il2CppReferenceArray_1_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrashItem>>(intPtr2) : null;
		}

		// Token: 0x060077E0 RID: 30688 RVA: 0x0020C370 File Offset: 0x0020A570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233897, XrefRangeEnd = 233898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashRemovalVolume() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashRemovalVolume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060077E1 RID: 30689 RVA: 0x0003881B File Offset: 0x00036A1B
		public TrashRemovalVolume(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002419 RID: 9241
		// (get) Token: 0x060077E2 RID: 30690 RVA: 0x0020C3AC File Offset: 0x0020A5AC
		// (set) Token: 0x060077E3 RID: 30691 RVA: 0x00038824 File Offset: 0x00036A24
		public unsafe BoxCollider Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashRemovalVolume.NativeFieldInfoPtr_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashRemovalVolume.NativeFieldInfoPtr_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700241A RID: 9242
		// (get) Token: 0x060077E4 RID: 30692 RVA: 0x0020C3DC File Offset: 0x0020A5DC
		// (set) Token: 0x060077E5 RID: 30693 RVA: 0x00038843 File Offset: 0x00036A43
		public unsafe float RemovalChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashRemovalVolume.NativeFieldInfoPtr_RemovalChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashRemovalVolume.NativeFieldInfoPtr_RemovalChance)) = value;
			}
		}

		// Token: 0x040051F1 RID: 20977
		private static readonly IntPtr NativeFieldInfoPtr_Collider;

		// Token: 0x040051F2 RID: 20978
		private static readonly IntPtr NativeFieldInfoPtr_RemovalChance;

		// Token: 0x040051F3 RID: 20979
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040051F4 RID: 20980
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040051F5 RID: 20981
		private static readonly IntPtr NativeMethodInfoPtr_SleepStart_Private_Void_0;

		// Token: 0x040051F6 RID: 20982
		private static readonly IntPtr NativeMethodInfoPtr_GetTrash_Private_Il2CppReferenceArray_1_TrashItem_0;

		// Token: 0x040051F7 RID: 20983
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
