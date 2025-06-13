using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Misc;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003D4 RID: 980
	public class BlinkingLight : MonoBehaviour
	{
		// Token: 0x06004B4F RID: 19279 RVA: 0x0016FB34 File Offset: 0x0016DD34
		// Note: this type is marked as 'beforefieldinit'.
		static BlinkingLight()
		{
			Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "BlinkingLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr);
			BlinkingLight.NativeFieldInfoPtr_IsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "IsOn");
			BlinkingLight.NativeFieldInfoPtr_OnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "OnTime");
			BlinkingLight.NativeFieldInfoPtr_OffTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "OffTime");
			BlinkingLight.NativeFieldInfoPtr_light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "light");
			BlinkingLight.NativeFieldInfoPtr_blinkRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "blinkRoutine");
			BlinkingLight.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, 100672721);
			BlinkingLight.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, 100672722);
			BlinkingLight.NativeMethodInfoPtr_Blink_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, 100672723);
			BlinkingLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, 100672724);
		}

		// Token: 0x06004B50 RID: 19280 RVA: 0x0016FC18 File Offset: 0x0016DE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168210, XrefRangeEnd = 168214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B51 RID: 19281 RVA: 0x0016FC4C File Offset: 0x0016DE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168214, XrefRangeEnd = 168221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B52 RID: 19282 RVA: 0x0016FC80 File Offset: 0x0016DE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168221, XrefRangeEnd = 168226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Blink()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight.NativeMethodInfoPtr_Blink_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06004B53 RID: 19283 RVA: 0x0016FCC0 File Offset: 0x0016DEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168226, XrefRangeEnd = 168227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlinkingLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B54 RID: 19284 RVA: 0x00024155 File Offset: 0x00022355
		public BlinkingLight(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700166B RID: 5739
		// (get) Token: 0x06004B55 RID: 19285 RVA: 0x0016FCFC File Offset: 0x0016DEFC
		// (set) Token: 0x06004B56 RID: 19286 RVA: 0x0002415E File Offset: 0x0002235E
		public unsafe bool IsOn
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_IsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_IsOn)) = value;
			}
		}

		// Token: 0x1700166C RID: 5740
		// (get) Token: 0x06004B57 RID: 19287 RVA: 0x0016FD24 File Offset: 0x0016DF24
		// (set) Token: 0x06004B58 RID: 19288 RVA: 0x00024179 File Offset: 0x00022379
		public unsafe float OnTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_OnTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_OnTime)) = value;
			}
		}

		// Token: 0x1700166D RID: 5741
		// (get) Token: 0x06004B59 RID: 19289 RVA: 0x0016FD4C File Offset: 0x0016DF4C
		// (set) Token: 0x06004B5A RID: 19290 RVA: 0x00024194 File Offset: 0x00022394
		public unsafe float OffTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_OffTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_OffTime)) = value;
			}
		}

		// Token: 0x1700166E RID: 5742
		// (get) Token: 0x06004B5B RID: 19291 RVA: 0x0016FD74 File Offset: 0x0016DF74
		// (set) Token: 0x06004B5C RID: 19292 RVA: 0x000241AF File Offset: 0x000223AF
		public unsafe ToggleableLight light
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_light);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleableLight>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700166F RID: 5743
		// (get) Token: 0x06004B5D RID: 19293 RVA: 0x0016FDA4 File Offset: 0x0016DFA4
		// (set) Token: 0x06004B5E RID: 19294 RVA: 0x000241CE File Offset: 0x000223CE
		public unsafe Coroutine blinkRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_blinkRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_blinkRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040032C2 RID: 12994
		private static readonly System.IntPtr NativeFieldInfoPtr_IsOn;

		// Token: 0x040032C3 RID: 12995
		private static readonly System.IntPtr NativeFieldInfoPtr_OnTime;

		// Token: 0x040032C4 RID: 12996
		private static readonly System.IntPtr NativeFieldInfoPtr_OffTime;

		// Token: 0x040032C5 RID: 12997
		private static readonly System.IntPtr NativeFieldInfoPtr_light;

		// Token: 0x040032C6 RID: 12998
		private static readonly System.IntPtr NativeFieldInfoPtr_blinkRoutine;

		// Token: 0x040032C7 RID: 12999
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040032C8 RID: 13000
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040032C9 RID: 13001
		private static readonly System.IntPtr NativeMethodInfoPtr_Blink_Private_IEnumerator_0;

		// Token: 0x040032CA RID: 13002
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009D0 RID: 2512
		[ObfuscatedName("ScheduleOne.Lighting.BlinkingLight+<Blink>d__7")]
		public sealed class _Blink_d__7 : Il2CppSystem.Object
		{
			// Token: 0x0600CF33 RID: 53043 RVA: 0x00323D2C File Offset: 0x00321F2C
			// Note: this type is marked as 'beforefieldinit'.
			static _Blink_d__7()
			{
				Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "<Blink>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr);
				BlinkingLight._Blink_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, "<>1__state");
				BlinkingLight._Blink_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, "<>2__current");
				BlinkingLight._Blink_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, "<>4__this");
				BlinkingLight._Blink_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, 100672725);
				BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, 100672726);
				BlinkingLight._Blink_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, 100672727);
				BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, 100672728);
				BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, 100672729);
				BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, 100672730);
			}

			// Token: 0x0600CF34 RID: 53044 RVA: 0x00323E0C File Offset: 0x0032200C
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Blink_d__7(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight._Blink_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF35 RID: 53045 RVA: 0x00323E54 File Offset: 0x00322054
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF36 RID: 53046 RVA: 0x00323E88 File Offset: 0x00322088
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168204, XrefRangeEnd = 168205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BlinkingLight._Blink_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004041 RID: 16449
			// (get) Token: 0x0600CF37 RID: 53047 RVA: 0x00323EC4 File Offset: 0x003220C4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CF38 RID: 53048 RVA: 0x00323F04 File Offset: 0x00322104
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168205, XrefRangeEnd = 168210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004042 RID: 16450
			// (get) Token: 0x0600CF39 RID: 53049 RVA: 0x00323F38 File Offset: 0x00322138
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CF3A RID: 53050 RVA: 0x000646E3 File Offset: 0x000628E3
			public _Blink_d__7(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700403E RID: 16446
			// (get) Token: 0x0600CF3B RID: 53051 RVA: 0x00323F78 File Offset: 0x00322178
			// (set) Token: 0x0600CF3C RID: 53052 RVA: 0x000646EC File Offset: 0x000628EC
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight._Blink_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight._Blink_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700403F RID: 16447
			// (get) Token: 0x0600CF3D RID: 53053 RVA: 0x00323FA0 File Offset: 0x003221A0
			// (set) Token: 0x0600CF3E RID: 53054 RVA: 0x00064707 File Offset: 0x00062907
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight._Blink_d__7.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight._Blink_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004040 RID: 16448
			// (get) Token: 0x0600CF3F RID: 53055 RVA: 0x00323FD0 File Offset: 0x003221D0
			// (set) Token: 0x0600CF40 RID: 53056 RVA: 0x00064726 File Offset: 0x00062926
			public unsafe BlinkingLight __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight._Blink_d__7.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlinkingLight>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight._Blink_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C34 RID: 35892
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008C35 RID: 35893
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008C36 RID: 35894
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C37 RID: 35895
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008C38 RID: 35896
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C39 RID: 35897
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008C3A RID: 35898
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008C3B RID: 35899
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C3C RID: 35900
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
