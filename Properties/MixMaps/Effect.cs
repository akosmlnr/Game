using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Properties.MixMaps
{
	// Token: 0x020001FD RID: 509
	public class Effect : MonoBehaviour
	{
		// Token: 0x060028EF RID: 10479 RVA: 0x000F4D80 File Offset: 0x000F2F80
		// Note: this type is marked as 'beforefieldinit'.
		static Effect()
		{
			Il2CppClassPointerStore<Effect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties.MixMaps", "Effect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Effect>.NativeClassPtr);
			Effect.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect>.NativeClassPtr, "Property");
			Effect.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect>.NativeClassPtr, "Radius");
			Effect.NativeMethodInfoPtr_get_Position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect>.NativeClassPtr, 100667953);
			Effect.NativeMethodInfoPtr_OnValidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect>.NativeClassPtr, 100667954);
			Effect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect>.NativeClassPtr, 100667955);
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x060028F0 RID: 10480 RVA: 0x000F4E14 File Offset: 0x000F3014
		public unsafe Vector2 Position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121932, XrefRangeEnd = 121936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Effect.NativeMethodInfoPtr_get_Position_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x000F4E50 File Offset: 0x000F3050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121936, XrefRangeEnd = 121942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Effect.NativeMethodInfoPtr_OnValidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x000F4E84 File Offset: 0x000F3084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Effect() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Effect>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Effect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x00016233 File Offset: 0x00014433
		public Effect(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x060028F4 RID: 10484 RVA: 0x000F4EC0 File Offset: 0x000F30C0
		// (set) Token: 0x060028F5 RID: 10485 RVA: 0x0001623C File Offset: 0x0001443C
		public unsafe Property Property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_Property);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x060028F6 RID: 10486 RVA: 0x000F4EF0 File Offset: 0x000F30F0
		// (set) Token: 0x060028F7 RID: 10487 RVA: 0x0001625B File Offset: 0x0001445B
		public unsafe float Radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_Radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_Radius)) = value;
			}
		}

		// Token: 0x04001B2D RID: 6957
		private static readonly IntPtr NativeFieldInfoPtr_Property;

		// Token: 0x04001B2E RID: 6958
		private static readonly IntPtr NativeFieldInfoPtr_Radius;

		// Token: 0x04001B2F RID: 6959
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector2_0;

		// Token: 0x04001B30 RID: 6960
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Public_Void_0;

		// Token: 0x04001B31 RID: 6961
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
