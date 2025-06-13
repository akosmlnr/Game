using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Property.Utilities
{
	// Token: 0x02000537 RID: 1335
	public class CosmeticPowerLine : MonoBehaviour
	{
		// Token: 0x06007594 RID: 30100 RVA: 0x00203200 File Offset: 0x00201400
		// Note: this type is marked as 'beforefieldinit'.
		static CosmeticPowerLine()
		{
			Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property.Utilities", "CosmeticPowerLine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr);
			CosmeticPowerLine.NativeFieldInfoPtr_startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr, "startPoint");
			CosmeticPowerLine.NativeFieldInfoPtr_endPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr, "endPoint");
			CosmeticPowerLine.NativeFieldInfoPtr_segments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr, "segments");
			CosmeticPowerLine.NativeFieldInfoPtr_LengthFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr, "LengthFactor");
			CosmeticPowerLine.NativeMethodInfoPtr_Draw_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr, 100678176);
			CosmeticPowerLine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr, 100678177);
		}

		// Token: 0x06007595 RID: 30101 RVA: 0x002032A8 File Offset: 0x002014A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230003, XrefRangeEnd = 230015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Draw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CosmeticPowerLine.NativeMethodInfoPtr_Draw_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007596 RID: 30102 RVA: 0x002032DC File Offset: 0x002014DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230015, XrefRangeEnd = 230023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CosmeticPowerLine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CosmeticPowerLine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007597 RID: 30103 RVA: 0x00037A39 File Offset: 0x00035C39
		public CosmeticPowerLine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002374 RID: 9076
		// (get) Token: 0x06007598 RID: 30104 RVA: 0x00203318 File Offset: 0x00201518
		// (set) Token: 0x06007599 RID: 30105 RVA: 0x00037A42 File Offset: 0x00035C42
		public unsafe Transform startPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CosmeticPowerLine.NativeFieldInfoPtr_startPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CosmeticPowerLine.NativeFieldInfoPtr_startPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002375 RID: 9077
		// (get) Token: 0x0600759A RID: 30106 RVA: 0x00203348 File Offset: 0x00201548
		// (set) Token: 0x0600759B RID: 30107 RVA: 0x00037A61 File Offset: 0x00035C61
		public unsafe Transform endPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CosmeticPowerLine.NativeFieldInfoPtr_endPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CosmeticPowerLine.NativeFieldInfoPtr_endPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002376 RID: 9078
		// (get) Token: 0x0600759C RID: 30108 RVA: 0x00203378 File Offset: 0x00201578
		// (set) Token: 0x0600759D RID: 30109 RVA: 0x00037A80 File Offset: 0x00035C80
		public unsafe List<Transform> segments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CosmeticPowerLine.NativeFieldInfoPtr_segments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CosmeticPowerLine.NativeFieldInfoPtr_segments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002377 RID: 9079
		// (get) Token: 0x0600759E RID: 30110 RVA: 0x002033A8 File Offset: 0x002015A8
		// (set) Token: 0x0600759F RID: 30111 RVA: 0x00037A9F File Offset: 0x00035C9F
		public unsafe float LengthFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CosmeticPowerLine.NativeFieldInfoPtr_LengthFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CosmeticPowerLine.NativeFieldInfoPtr_LengthFactor)) = value;
			}
		}

		// Token: 0x04005048 RID: 20552
		private static readonly IntPtr NativeFieldInfoPtr_startPoint;

		// Token: 0x04005049 RID: 20553
		private static readonly IntPtr NativeFieldInfoPtr_endPoint;

		// Token: 0x0400504A RID: 20554
		private static readonly IntPtr NativeFieldInfoPtr_segments;

		// Token: 0x0400504B RID: 20555
		private static readonly IntPtr NativeFieldInfoPtr_LengthFactor;

		// Token: 0x0400504C RID: 20556
		private static readonly IntPtr NativeMethodInfoPtr_Draw_Public_Void_0;

		// Token: 0x0400504D RID: 20557
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
