using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x020005AF RID: 1455
	public class LiquidLevelVisuals : MonoBehaviour
	{
		// Token: 0x06007F28 RID: 32552 RVA: 0x00223CD0 File Offset: 0x00221ED0
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidLevelVisuals()
		{
			Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "LiquidLevelVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr);
			LiquidLevelVisuals.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr, "Container");
			LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr, "LiquidSurface");
			LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr, "LiquidSurface_Min");
			LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr, "LiquidSurface_Max");
			LiquidLevelVisuals.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr, 100679321);
			LiquidLevelVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr, 100679322);
		}

		// Token: 0x06007F29 RID: 32553 RVA: 0x00223D78 File Offset: 0x00221F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241527, XrefRangeEnd = 241540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidLevelVisuals.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F2A RID: 32554 RVA: 0x00223DAC File Offset: 0x00221FAC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidLevelVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidLevelVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F2B RID: 32555 RVA: 0x0003C1ED File Offset: 0x0003A3ED
		public LiquidLevelVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002642 RID: 9794
		// (get) Token: 0x06007F2C RID: 32556 RVA: 0x00223DE8 File Offset: 0x00221FE8
		// (set) Token: 0x06007F2D RID: 32557 RVA: 0x0003C1F6 File Offset: 0x0003A3F6
		public unsafe LiquidContainer Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002643 RID: 9795
		// (get) Token: 0x06007F2E RID: 32558 RVA: 0x00223E18 File Offset: 0x00222018
		// (set) Token: 0x06007F2F RID: 32559 RVA: 0x0003C215 File Offset: 0x0003A415
		public unsafe Transform LiquidSurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002644 RID: 9796
		// (get) Token: 0x06007F30 RID: 32560 RVA: 0x00223E48 File Offset: 0x00222048
		// (set) Token: 0x06007F31 RID: 32561 RVA: 0x0003C234 File Offset: 0x0003A434
		public unsafe Transform LiquidSurface_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002645 RID: 9797
		// (get) Token: 0x06007F32 RID: 32562 RVA: 0x00223E78 File Offset: 0x00222078
		// (set) Token: 0x06007F33 RID: 32563 RVA: 0x0003C253 File Offset: 0x0003A453
		public unsafe Transform LiquidSurface_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005691 RID: 22161
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005692 RID: 22162
		private static readonly IntPtr NativeFieldInfoPtr_LiquidSurface;

		// Token: 0x04005693 RID: 22163
		private static readonly IntPtr NativeFieldInfoPtr_LiquidSurface_Min;

		// Token: 0x04005694 RID: 22164
		private static readonly IntPtr NativeFieldInfoPtr_LiquidSurface_Max;

		// Token: 0x04005695 RID: 22165
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005696 RID: 22166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
