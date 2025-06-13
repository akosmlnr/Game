using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.GameTime
{
	// Token: 0x0200019B RID: 411
	public class AnalogueClock : MonoBehaviour
	{
		// Token: 0x06002116 RID: 8470 RVA: 0x000DA594 File Offset: 0x000D8794
		// Note: this type is marked as 'beforefieldinit'.
		static AnalogueClock()
		{
			Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.GameTime", "AnalogueClock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr);
			AnalogueClock.NativeFieldInfoPtr_MinHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, "MinHand");
			AnalogueClock.NativeFieldInfoPtr_HourHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, "HourHand");
			AnalogueClock.NativeFieldInfoPtr_RotationAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, "RotationAxis");
			AnalogueClock.NativeFieldInfoPtr_onNoon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, "onNoon");
			AnalogueClock.NativeFieldInfoPtr_onMidnight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, "onMidnight");
			AnalogueClock.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, 100667026);
			AnalogueClock.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, 100667027);
			AnalogueClock.NativeMethodInfoPtr_MinPass_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, 100667028);
			AnalogueClock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, 100667029);
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x000DA678 File Offset: 0x000D8878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112685, XrefRangeEnd = 112718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalogueClock.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x000DA6AC File Offset: 0x000D88AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112718, XrefRangeEnd = 112736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalogueClock.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x000DA6E0 File Offset: 0x000D88E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112744, RefRangeEnd = 112745, XrefRangeStart = 112736, XrefRangeEnd = 112744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalogueClock.NativeMethodInfoPtr_MinPass_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x000DA714 File Offset: 0x000D8914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112745, XrefRangeEnd = 112748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalogueClock() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalogueClock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x0001284B File Offset: 0x00010A4B
		public AnalogueClock(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x0600211C RID: 8476 RVA: 0x000DA750 File Offset: 0x000D8950
		// (set) Token: 0x0600211D RID: 8477 RVA: 0x00012854 File Offset: 0x00010A54
		public unsafe Transform MinHand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_MinHand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_MinHand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x0600211E RID: 8478 RVA: 0x000DA780 File Offset: 0x000D8980
		// (set) Token: 0x0600211F RID: 8479 RVA: 0x00012873 File Offset: 0x00010A73
		public unsafe Transform HourHand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_HourHand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_HourHand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06002120 RID: 8480 RVA: 0x000DA7B0 File Offset: 0x000D89B0
		// (set) Token: 0x06002121 RID: 8481 RVA: 0x00012892 File Offset: 0x00010A92
		public unsafe Vector3 RotationAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_RotationAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_RotationAxis)) = value;
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06002122 RID: 8482 RVA: 0x000DA7D8 File Offset: 0x000D89D8
		// (set) Token: 0x06002123 RID: 8483 RVA: 0x000128AD File Offset: 0x00010AAD
		public unsafe UnityEvent onNoon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_onNoon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_onNoon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06002124 RID: 8484 RVA: 0x000DA808 File Offset: 0x000D8A08
		// (set) Token: 0x06002125 RID: 8485 RVA: 0x000128CC File Offset: 0x00010ACC
		public unsafe UnityEvent onMidnight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_onMidnight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_onMidnight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040015EC RID: 5612
		private static readonly IntPtr NativeFieldInfoPtr_MinHand;

		// Token: 0x040015ED RID: 5613
		private static readonly IntPtr NativeFieldInfoPtr_HourHand;

		// Token: 0x040015EE RID: 5614
		private static readonly IntPtr NativeFieldInfoPtr_RotationAxis;

		// Token: 0x040015EF RID: 5615
		private static readonly IntPtr NativeFieldInfoPtr_onNoon;

		// Token: 0x040015F0 RID: 5616
		private static readonly IntPtr NativeFieldInfoPtr_onMidnight;

		// Token: 0x040015F1 RID: 5617
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040015F2 RID: 5618
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040015F3 RID: 5619
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Public_Void_0;

		// Token: 0x040015F4 RID: 5620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
