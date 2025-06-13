using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200068F RID: 1679
	public class DestroyUIAtBounds : MonoBehaviour
	{
		// Token: 0x060094FB RID: 38139 RVA: 0x00268D14 File Offset: 0x00266F14
		// Note: this type is marked as 'beforefieldinit'.
		static DestroyUIAtBounds()
		{
			Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DestroyUIAtBounds");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr);
			DestroyUIAtBounds.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr, "Rect");
			DestroyUIAtBounds.NativeFieldInfoPtr_MinBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr, "MinBounds");
			DestroyUIAtBounds.NativeFieldInfoPtr_MaxBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr, "MaxBounds");
			DestroyUIAtBounds.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr, 100681885);
			DestroyUIAtBounds.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr, 100681886);
		}

		// Token: 0x060094FC RID: 38140 RVA: 0x00268DA8 File Offset: 0x00266FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268799, XrefRangeEnd = 268808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DestroyUIAtBounds.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060094FD RID: 38141 RVA: 0x00268DDC File Offset: 0x00266FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268808, XrefRangeEnd = 268809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DestroyUIAtBounds() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DestroyUIAtBounds.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060094FE RID: 38142 RVA: 0x00047D68 File Offset: 0x00045F68
		public DestroyUIAtBounds(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D72 RID: 11634
		// (get) Token: 0x060094FF RID: 38143 RVA: 0x00268E18 File Offset: 0x00267018
		// (set) Token: 0x06009500 RID: 38144 RVA: 0x00047D71 File Offset: 0x00045F71
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyUIAtBounds.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyUIAtBounds.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D73 RID: 11635
		// (get) Token: 0x06009501 RID: 38145 RVA: 0x00268E48 File Offset: 0x00267048
		// (set) Token: 0x06009502 RID: 38146 RVA: 0x00047D90 File Offset: 0x00045F90
		public unsafe Vector2 MinBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyUIAtBounds.NativeFieldInfoPtr_MinBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyUIAtBounds.NativeFieldInfoPtr_MinBounds)) = value;
			}
		}

		// Token: 0x17002D74 RID: 11636
		// (get) Token: 0x06009503 RID: 38147 RVA: 0x00268E70 File Offset: 0x00267070
		// (set) Token: 0x06009504 RID: 38148 RVA: 0x00047DAB File Offset: 0x00045FAB
		public unsafe Vector2 MaxBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyUIAtBounds.NativeFieldInfoPtr_MaxBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyUIAtBounds.NativeFieldInfoPtr_MaxBounds)) = value;
			}
		}

		// Token: 0x040064AB RID: 25771
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x040064AC RID: 25772
		private static readonly IntPtr NativeFieldInfoPtr_MinBounds;

		// Token: 0x040064AD RID: 25773
		private static readonly IntPtr NativeFieldInfoPtr_MaxBounds;

		// Token: 0x040064AE RID: 25774
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040064AF RID: 25775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
