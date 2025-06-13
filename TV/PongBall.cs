using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x02000191 RID: 401
	public class PongBall : MonoBehaviour
	{
		// Token: 0x06001FD4 RID: 8148 RVA: 0x000D6C40 File Offset: 0x000D4E40
		// Note: this type is marked as 'beforefieldinit'.
		static PongBall()
		{
			Il2CppClassPointerStore<PongBall>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "PongBall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PongBall>.NativeClassPtr);
			PongBall.NativeFieldInfoPtr_Game = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongBall>.NativeClassPtr, "Game");
			PongBall.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongBall>.NativeClassPtr, "Rect");
			PongBall.NativeFieldInfoPtr_RB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongBall>.NativeClassPtr, "RB");
			PongBall.NativeFieldInfoPtr_RandomForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongBall>.NativeClassPtr, "RandomForce");
			PongBall.NativeFieldInfoPtr_onHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongBall>.NativeClassPtr, "onHit");
			PongBall.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongBall>.NativeClassPtr, 100666922);
			PongBall.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongBall>.NativeClassPtr, 100666923);
			PongBall.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongBall>.NativeClassPtr, 100666924);
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x000D6D10 File Offset: 0x000D4F10
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongBall.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x000D6D44 File Offset: 0x000D4F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111722, XrefRangeEnd = 111753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongBall.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x000D6D88 File Offset: 0x000D4F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PongBall() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PongBall>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongBall.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x00011CA5 File Offset: 0x0000FEA5
		public PongBall(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x000D6DC4 File Offset: 0x000D4FC4
		// (set) Token: 0x06001FDA RID: 8154 RVA: 0x00011CAE File Offset: 0x0000FEAE
		public unsafe Pong Game
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_Game);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pong>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_Game), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x000D6DF4 File Offset: 0x000D4FF4
		// (set) Token: 0x06001FDC RID: 8156 RVA: 0x00011CCD File Offset: 0x0000FECD
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06001FDD RID: 8157 RVA: 0x000D6E24 File Offset: 0x000D5024
		// (set) Token: 0x06001FDE RID: 8158 RVA: 0x00011CEC File Offset: 0x0000FEEC
		public unsafe Rigidbody RB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_RB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_RB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06001FDF RID: 8159 RVA: 0x000D6E54 File Offset: 0x000D5054
		// (set) Token: 0x06001FE0 RID: 8160 RVA: 0x00011D0B File Offset: 0x0000FF0B
		public unsafe float RandomForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_RandomForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_RandomForce)) = value;
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x000D6E7C File Offset: 0x000D507C
		// (set) Token: 0x06001FE2 RID: 8162 RVA: 0x00011D26 File Offset: 0x0000FF26
		public unsafe UnityEvent onHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_onHit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_onHit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001525 RID: 5413
		private static readonly IntPtr NativeFieldInfoPtr_Game;

		// Token: 0x04001526 RID: 5414
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x04001527 RID: 5415
		private static readonly IntPtr NativeFieldInfoPtr_RB;

		// Token: 0x04001528 RID: 5416
		private static readonly IntPtr NativeFieldInfoPtr_RandomForce;

		// Token: 0x04001529 RID: 5417
		private static readonly IntPtr NativeFieldInfoPtr_onHit;

		// Token: 0x0400152A RID: 5418
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x0400152B RID: 5419
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;

		// Token: 0x0400152C RID: 5420
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
