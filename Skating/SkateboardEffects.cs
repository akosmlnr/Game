using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Skating
{
	// Token: 0x020001B3 RID: 435
	public class SkateboardEffects : MonoBehaviour
	{
		// Token: 0x06002479 RID: 9337 RVA: 0x000E4A54 File Offset: 0x000E2C54
		// Note: this type is marked as 'beforefieldinit'.
		static SkateboardEffects()
		{
			Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Skating", "SkateboardEffects");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr);
			SkateboardEffects.NativeFieldInfoPtr_skateboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr, "skateboard");
			SkateboardEffects.NativeFieldInfoPtr_Trails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr, "Trails");
			SkateboardEffects.NativeFieldInfoPtr_trailsOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr, "trailsOpacity");
			SkateboardEffects.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr, 100667377);
			SkateboardEffects.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr, 100667378);
			SkateboardEffects.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr, 100667379);
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x000E4AFC File Offset: 0x000E2CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116305, XrefRangeEnd = 116310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardEffects.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x000E4B30 File Offset: 0x000E2D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116310, XrefRangeEnd = 116314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardEffects.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x000E4B64 File Offset: 0x000E2D64
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkateboardEffects() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardEffects.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x0001465F File Offset: 0x0001285F
		public SkateboardEffects(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x0600247E RID: 9342 RVA: 0x000E4BA0 File Offset: 0x000E2DA0
		// (set) Token: 0x0600247F RID: 9343 RVA: 0x00014668 File Offset: 0x00012868
		public unsafe Skateboard skateboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardEffects.NativeFieldInfoPtr_skateboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardEffects.NativeFieldInfoPtr_skateboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x06002480 RID: 9344 RVA: 0x000E4BD0 File Offset: 0x000E2DD0
		// (set) Token: 0x06002481 RID: 9345 RVA: 0x00014687 File Offset: 0x00012887
		public unsafe Il2CppReferenceArray<TrailRenderer> Trails
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardEffects.NativeFieldInfoPtr_Trails);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrailRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardEffects.NativeFieldInfoPtr_Trails), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x06002482 RID: 9346 RVA: 0x000E4C00 File Offset: 0x000E2E00
		// (set) Token: 0x06002483 RID: 9347 RVA: 0x000146A6 File Offset: 0x000128A6
		public unsafe float trailsOpacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardEffects.NativeFieldInfoPtr_trailsOpacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardEffects.NativeFieldInfoPtr_trailsOpacity)) = value;
			}
		}

		// Token: 0x0400182C RID: 6188
		private static readonly IntPtr NativeFieldInfoPtr_skateboard;

		// Token: 0x0400182D RID: 6189
		private static readonly IntPtr NativeFieldInfoPtr_Trails;

		// Token: 0x0400182E RID: 6190
		private static readonly IntPtr NativeFieldInfoPtr_trailsOpacity;

		// Token: 0x0400182F RID: 6191
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001830 RID: 6192
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04001831 RID: 6193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
