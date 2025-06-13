using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Skating
{
	// Token: 0x020001B4 RID: 436
	public class SkateboardVisuals : MonoBehaviour
	{
		// Token: 0x06002484 RID: 9348 RVA: 0x000E4C28 File Offset: 0x000E2E28
		// Note: this type is marked as 'beforefieldinit'.
		static SkateboardVisuals()
		{
			Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Skating", "SkateboardVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr);
			SkateboardVisuals.NativeFieldInfoPtr_MaxBoardLean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, "MaxBoardLean");
			SkateboardVisuals.NativeFieldInfoPtr_BoardLeanRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, "BoardLeanRate");
			SkateboardVisuals.NativeFieldInfoPtr_Board = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, "Board");
			SkateboardVisuals.NativeFieldInfoPtr_skateboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, "skateboard");
			SkateboardVisuals.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, 100667380);
			SkateboardVisuals.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, 100667381);
			SkateboardVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, 100667382);
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x000E4CE4 File Offset: 0x000E2EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116314, XrefRangeEnd = 116318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardVisuals.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x000E4D18 File Offset: 0x000E2F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116318, XrefRangeEnd = 116323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardVisuals.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x000E4D4C File Offset: 0x000E2F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116323, XrefRangeEnd = 116324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkateboardVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x000146C1 File Offset: 0x000128C1
		public SkateboardVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x06002489 RID: 9353 RVA: 0x000E4D88 File Offset: 0x000E2F88
		// (set) Token: 0x0600248A RID: 9354 RVA: 0x000146CA File Offset: 0x000128CA
		public unsafe float MaxBoardLean
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_MaxBoardLean);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_MaxBoardLean)) = value;
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x0600248B RID: 9355 RVA: 0x000E4DB0 File Offset: 0x000E2FB0
		// (set) Token: 0x0600248C RID: 9356 RVA: 0x000146E5 File Offset: 0x000128E5
		public unsafe float BoardLeanRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_BoardLeanRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_BoardLeanRate)) = value;
			}
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x0600248D RID: 9357 RVA: 0x000E4DD8 File Offset: 0x000E2FD8
		// (set) Token: 0x0600248E RID: 9358 RVA: 0x00014700 File Offset: 0x00012900
		public unsafe Transform Board
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_Board);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_Board), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x0600248F RID: 9359 RVA: 0x000E4E08 File Offset: 0x000E3008
		// (set) Token: 0x06002490 RID: 9360 RVA: 0x0001471F File Offset: 0x0001291F
		public unsafe Skateboard skateboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_skateboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_skateboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001832 RID: 6194
		private static readonly IntPtr NativeFieldInfoPtr_MaxBoardLean;

		// Token: 0x04001833 RID: 6195
		private static readonly IntPtr NativeFieldInfoPtr_BoardLeanRate;

		// Token: 0x04001834 RID: 6196
		private static readonly IntPtr NativeFieldInfoPtr_Board;

		// Token: 0x04001835 RID: 6197
		private static readonly IntPtr NativeFieldInfoPtr_skateboard;

		// Token: 0x04001836 RID: 6198
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001837 RID: 6199
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04001838 RID: 6200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
