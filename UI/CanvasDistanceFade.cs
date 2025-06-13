using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200064D RID: 1613
	public class CanvasDistanceFade : MonoBehaviour
	{
		// Token: 0x06008D56 RID: 36182 RVA: 0x00252138 File Offset: 0x00250338
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasDistanceFade()
		{
			Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CanvasDistanceFade");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr);
			CanvasDistanceFade.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr, "CanvasGroup");
			CanvasDistanceFade.NativeFieldInfoPtr_MinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr, "MinDistance");
			CanvasDistanceFade.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr, "MaxDistance");
			CanvasDistanceFade.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr, 100680956);
			CanvasDistanceFade.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr, 100680957);
		}

		// Token: 0x06008D57 RID: 36183 RVA: 0x002521CC File Offset: 0x002503CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258814, XrefRangeEnd = 258831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasDistanceFade.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D58 RID: 36184 RVA: 0x00252200 File Offset: 0x00250400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258831, XrefRangeEnd = 258832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanvasDistanceFade() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasDistanceFade.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D59 RID: 36185 RVA: 0x00043644 File Offset: 0x00041844
		public CanvasDistanceFade(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002ADF RID: 10975
		// (get) Token: 0x06008D5A RID: 36186 RVA: 0x0025223C File Offset: 0x0025043C
		// (set) Token: 0x06008D5B RID: 36187 RVA: 0x0004364D File Offset: 0x0004184D
		public unsafe CanvasGroup CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasDistanceFade.NativeFieldInfoPtr_CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasDistanceFade.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AE0 RID: 10976
		// (get) Token: 0x06008D5C RID: 36188 RVA: 0x0025226C File Offset: 0x0025046C
		// (set) Token: 0x06008D5D RID: 36189 RVA: 0x0004366C File Offset: 0x0004186C
		public unsafe float MinDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasDistanceFade.NativeFieldInfoPtr_MinDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasDistanceFade.NativeFieldInfoPtr_MinDistance)) = value;
			}
		}

		// Token: 0x17002AE1 RID: 10977
		// (get) Token: 0x06008D5E RID: 36190 RVA: 0x00252294 File Offset: 0x00250494
		// (set) Token: 0x06008D5F RID: 36191 RVA: 0x00043687 File Offset: 0x00041887
		public unsafe float MaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasDistanceFade.NativeFieldInfoPtr_MaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasDistanceFade.NativeFieldInfoPtr_MaxDistance)) = value;
			}
		}

		// Token: 0x04005FE1 RID: 24545
		private static readonly IntPtr NativeFieldInfoPtr_CanvasGroup;

		// Token: 0x04005FE2 RID: 24546
		private static readonly IntPtr NativeFieldInfoPtr_MinDistance;

		// Token: 0x04005FE3 RID: 24547
		private static readonly IntPtr NativeFieldInfoPtr_MaxDistance;

		// Token: 0x04005FE4 RID: 24548
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x04005FE5 RID: 24549
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
