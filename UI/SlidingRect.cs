using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000691 RID: 1681
	public class SlidingRect : MonoBehaviour
	{
		// Token: 0x06009519 RID: 38169 RVA: 0x00269240 File Offset: 0x00267440
		// Note: this type is marked as 'beforefieldinit'.
		static SlidingRect()
		{
			Il2CppClassPointerStore<SlidingRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "SlidingRect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr);
			SlidingRect.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, "Rect");
			SlidingRect.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, "Start");
			SlidingRect.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, "End");
			SlidingRect.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, "Duration");
			SlidingRect.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, "SpeedMultiplier");
			SlidingRect.NativeFieldInfoPtr__time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, "_time");
			SlidingRect.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, 100681893);
			SlidingRect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, 100681894);
		}

		// Token: 0x0600951A RID: 38170 RVA: 0x00269310 File Offset: 0x00267510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268867, XrefRangeEnd = 268871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingRect.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600951B RID: 38171 RVA: 0x00269344 File Offset: 0x00267544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268871, XrefRangeEnd = 268872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlidingRect() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingRect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600951C RID: 38172 RVA: 0x00047E81 File Offset: 0x00046081
		public SlidingRect(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D7B RID: 11643
		// (get) Token: 0x0600951D RID: 38173 RVA: 0x00269380 File Offset: 0x00267580
		// (set) Token: 0x0600951E RID: 38174 RVA: 0x00047E8A File Offset: 0x0004608A
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D7C RID: 11644
		// (get) Token: 0x0600951F RID: 38175 RVA: 0x002693B0 File Offset: 0x002675B0
		// (set) Token: 0x06009520 RID: 38176 RVA: 0x00047EA9 File Offset: 0x000460A9
		public unsafe Vector2 Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_Start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_Start)) = value;
			}
		}

		// Token: 0x17002D7D RID: 11645
		// (get) Token: 0x06009521 RID: 38177 RVA: 0x002693D8 File Offset: 0x002675D8
		// (set) Token: 0x06009522 RID: 38178 RVA: 0x00047EC4 File Offset: 0x000460C4
		public unsafe Vector2 End
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_End);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_End)) = value;
			}
		}

		// Token: 0x17002D7E RID: 11646
		// (get) Token: 0x06009523 RID: 38179 RVA: 0x00269400 File Offset: 0x00267600
		// (set) Token: 0x06009524 RID: 38180 RVA: 0x00047EDF File Offset: 0x000460DF
		public unsafe float Duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_Duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_Duration)) = value;
			}
		}

		// Token: 0x17002D7F RID: 11647
		// (get) Token: 0x06009525 RID: 38181 RVA: 0x00269428 File Offset: 0x00267628
		// (set) Token: 0x06009526 RID: 38182 RVA: 0x00047EFA File Offset: 0x000460FA
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x17002D80 RID: 11648
		// (get) Token: 0x06009527 RID: 38183 RVA: 0x00269450 File Offset: 0x00267650
		// (set) Token: 0x06009528 RID: 38184 RVA: 0x00047F15 File Offset: 0x00046115
		public unsafe float _time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr__time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr__time)) = value;
			}
		}

		// Token: 0x040064BC RID: 25788
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x040064BD RID: 25789
		private static readonly IntPtr NativeFieldInfoPtr_Start;

		// Token: 0x040064BE RID: 25790
		private static readonly IntPtr NativeFieldInfoPtr_End;

		// Token: 0x040064BF RID: 25791
		private static readonly IntPtr NativeFieldInfoPtr_Duration;

		// Token: 0x040064C0 RID: 25792
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x040064C1 RID: 25793
		private static readonly IntPtr NativeFieldInfoPtr__time;

		// Token: 0x040064C2 RID: 25794
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040064C3 RID: 25795
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
