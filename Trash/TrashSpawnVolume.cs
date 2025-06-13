using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x02000548 RID: 1352
	public class TrashSpawnVolume : MonoBehaviour
	{
		// Token: 0x060077E6 RID: 30694 RVA: 0x0020C404 File Offset: 0x0020A604
		// Note: this type is marked as 'beforefieldinit'.
		static TrashSpawnVolume()
		{
			Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashSpawnVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr);
			TrashSpawnVolume.NativeFieldInfoPtr_CreatonVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, "CreatonVolume");
			TrashSpawnVolume.NativeFieldInfoPtr_DetectionVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, "DetectionVolume");
			TrashSpawnVolume.NativeFieldInfoPtr_TrashLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, "TrashLimit");
			TrashSpawnVolume.NativeFieldInfoPtr_TrashSpawnChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, "TrashSpawnChance");
			TrashSpawnVolume.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, 100678504);
			TrashSpawnVolume.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, 100678505);
			TrashSpawnVolume.NativeMethodInfoPtr_SleepStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, 100678506);
			TrashSpawnVolume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, 100678507);
		}

		// Token: 0x060077E7 RID: 30695 RVA: 0x0020C4D4 File Offset: 0x0020A6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233898, XrefRangeEnd = 233910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashSpawnVolume.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060077E8 RID: 30696 RVA: 0x0020C508 File Offset: 0x0020A708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233910, XrefRangeEnd = 233924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashSpawnVolume.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060077E9 RID: 30697 RVA: 0x0020C53C File Offset: 0x0020A73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233924, XrefRangeEnd = 233972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashSpawnVolume.NativeMethodInfoPtr_SleepStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060077EA RID: 30698 RVA: 0x0020C570 File Offset: 0x0020A770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233972, XrefRangeEnd = 233973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashSpawnVolume() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashSpawnVolume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060077EB RID: 30699 RVA: 0x0003885E File Offset: 0x00036A5E
		public TrashSpawnVolume(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700241B RID: 9243
		// (get) Token: 0x060077EC RID: 30700 RVA: 0x0020C5AC File Offset: 0x0020A7AC
		// (set) Token: 0x060077ED RID: 30701 RVA: 0x00038867 File Offset: 0x00036A67
		public unsafe BoxCollider CreatonVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_CreatonVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_CreatonVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700241C RID: 9244
		// (get) Token: 0x060077EE RID: 30702 RVA: 0x0020C5DC File Offset: 0x0020A7DC
		// (set) Token: 0x060077EF RID: 30703 RVA: 0x00038886 File Offset: 0x00036A86
		public unsafe BoxCollider DetectionVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_DetectionVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_DetectionVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700241D RID: 9245
		// (get) Token: 0x060077F0 RID: 30704 RVA: 0x0020C60C File Offset: 0x0020A80C
		// (set) Token: 0x060077F1 RID: 30705 RVA: 0x000388A5 File Offset: 0x00036AA5
		public unsafe int TrashLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_TrashLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_TrashLimit)) = value;
			}
		}

		// Token: 0x1700241E RID: 9246
		// (get) Token: 0x060077F2 RID: 30706 RVA: 0x0020C634 File Offset: 0x0020A834
		// (set) Token: 0x060077F3 RID: 30707 RVA: 0x000388C0 File Offset: 0x00036AC0
		public unsafe float TrashSpawnChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_TrashSpawnChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_TrashSpawnChance)) = value;
			}
		}

		// Token: 0x040051F8 RID: 20984
		private static readonly IntPtr NativeFieldInfoPtr_CreatonVolume;

		// Token: 0x040051F9 RID: 20985
		private static readonly IntPtr NativeFieldInfoPtr_DetectionVolume;

		// Token: 0x040051FA RID: 20986
		private static readonly IntPtr NativeFieldInfoPtr_TrashLimit;

		// Token: 0x040051FB RID: 20987
		private static readonly IntPtr NativeFieldInfoPtr_TrashSpawnChance;

		// Token: 0x040051FC RID: 20988
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040051FD RID: 20989
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040051FE RID: 20990
		private static readonly IntPtr NativeMethodInfoPtr_SleepStart_Public_Void_0;

		// Token: 0x040051FF RID: 20991
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
