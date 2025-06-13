using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000753 RID: 1875
	public class CashCounter : MonoBehaviour
	{
		// Token: 0x0600A8AC RID: 43180 RVA: 0x002A5428 File Offset: 0x002A3628
		// Note: this type is marked as 'beforefieldinit'.
		static CashCounter()
		{
			Il2CppClassPointerStore<CashCounter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "CashCounter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashCounter>.NativeClassPtr);
			CashCounter.NativeFieldInfoPtr_NoteLerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "NoteLerpTime");
			CashCounter.NativeFieldInfoPtr_IsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "IsOn");
			CashCounter.NativeFieldInfoPtr_UpperNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "UpperNotes");
			CashCounter.NativeFieldInfoPtr_LowerNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "LowerNotes");
			CashCounter.NativeFieldInfoPtr_NoteStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "NoteStartPoint");
			CashCounter.NativeFieldInfoPtr_NoteEndPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "NoteEndPoint");
			CashCounter.NativeFieldInfoPtr_MovingNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "MovingNotes");
			CashCounter.NativeFieldInfoPtr_Audio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "Audio");
			CashCounter.NativeFieldInfoPtr_lerping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "lerping");
			CashCounter.NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, 100684028);
			CashCounter.NativeMethodInfoPtr_LerpNote_Private_IEnumerator_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, 100684029);
			CashCounter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, 100684030);
		}

		// Token: 0x0600A8AD RID: 43181 RVA: 0x002A5548 File Offset: 0x002A3748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294465, XrefRangeEnd = 294473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashCounter.NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8AE RID: 43182 RVA: 0x002A5584 File Offset: 0x002A3784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294473, XrefRangeEnd = 294479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LerpNote(Transform note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(note);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter.NativeMethodInfoPtr_LerpNote_Private_IEnumerator_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600A8AF RID: 43183 RVA: 0x002A55D4 File Offset: 0x002A37D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294479, XrefRangeEnd = 294487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashCounter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashCounter>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8B0 RID: 43184 RVA: 0x00052E64 File Offset: 0x00051064
		public CashCounter(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170033DB RID: 13275
		// (get) Token: 0x0600A8B1 RID: 43185 RVA: 0x002A5610 File Offset: 0x002A3810
		// (set) Token: 0x0600A8B2 RID: 43186 RVA: 0x00052E6D File Offset: 0x0005106D
		public unsafe static float NoteLerpTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CashCounter.NativeFieldInfoPtr_NoteLerpTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CashCounter.NativeFieldInfoPtr_NoteLerpTime, (void*)(&value));
			}
		}

		// Token: 0x170033DC RID: 13276
		// (get) Token: 0x0600A8B3 RID: 43187 RVA: 0x002A562C File Offset: 0x002A382C
		// (set) Token: 0x0600A8B4 RID: 43188 RVA: 0x00052E7B File Offset: 0x0005107B
		public unsafe bool IsOn
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_IsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_IsOn)) = value;
			}
		}

		// Token: 0x170033DD RID: 13277
		// (get) Token: 0x0600A8B5 RID: 43189 RVA: 0x002A5654 File Offset: 0x002A3854
		// (set) Token: 0x0600A8B6 RID: 43190 RVA: 0x00052E96 File Offset: 0x00051096
		public unsafe GameObject UpperNotes
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_UpperNotes);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_UpperNotes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033DE RID: 13278
		// (get) Token: 0x0600A8B7 RID: 43191 RVA: 0x002A5684 File Offset: 0x002A3884
		// (set) Token: 0x0600A8B8 RID: 43192 RVA: 0x00052EB5 File Offset: 0x000510B5
		public unsafe GameObject LowerNotes
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_LowerNotes);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_LowerNotes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033DF RID: 13279
		// (get) Token: 0x0600A8B9 RID: 43193 RVA: 0x002A56B4 File Offset: 0x002A38B4
		// (set) Token: 0x0600A8BA RID: 43194 RVA: 0x00052ED4 File Offset: 0x000510D4
		public unsafe Transform NoteStartPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_NoteStartPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_NoteStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033E0 RID: 13280
		// (get) Token: 0x0600A8BB RID: 43195 RVA: 0x002A56E4 File Offset: 0x002A38E4
		// (set) Token: 0x0600A8BC RID: 43196 RVA: 0x00052EF3 File Offset: 0x000510F3
		public unsafe Transform NoteEndPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_NoteEndPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_NoteEndPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033E1 RID: 13281
		// (get) Token: 0x0600A8BD RID: 43197 RVA: 0x002A5714 File Offset: 0x002A3914
		// (set) Token: 0x0600A8BE RID: 43198 RVA: 0x00052F12 File Offset: 0x00051112
		public unsafe List<Transform> MovingNotes
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_MovingNotes);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_MovingNotes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033E2 RID: 13282
		// (get) Token: 0x0600A8BF RID: 43199 RVA: 0x002A5744 File Offset: 0x002A3944
		// (set) Token: 0x0600A8C0 RID: 43200 RVA: 0x00052F31 File Offset: 0x00051131
		public unsafe AudioSourceController Audio
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_Audio);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_Audio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033E3 RID: 13283
		// (get) Token: 0x0600A8C1 RID: 43201 RVA: 0x002A5774 File Offset: 0x002A3974
		// (set) Token: 0x0600A8C2 RID: 43202 RVA: 0x00052F50 File Offset: 0x00051150
		public unsafe bool lerping
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_lerping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_lerping)) = value;
			}
		}

		// Token: 0x0400711E RID: 28958
		private static readonly System.IntPtr NativeFieldInfoPtr_NoteLerpTime;

		// Token: 0x0400711F RID: 28959
		private static readonly System.IntPtr NativeFieldInfoPtr_IsOn;

		// Token: 0x04007120 RID: 28960
		private static readonly System.IntPtr NativeFieldInfoPtr_UpperNotes;

		// Token: 0x04007121 RID: 28961
		private static readonly System.IntPtr NativeFieldInfoPtr_LowerNotes;

		// Token: 0x04007122 RID: 28962
		private static readonly System.IntPtr NativeFieldInfoPtr_NoteStartPoint;

		// Token: 0x04007123 RID: 28963
		private static readonly System.IntPtr NativeFieldInfoPtr_NoteEndPoint;

		// Token: 0x04007124 RID: 28964
		private static readonly System.IntPtr NativeFieldInfoPtr_MovingNotes;

		// Token: 0x04007125 RID: 28965
		private static readonly System.IntPtr NativeFieldInfoPtr_Audio;

		// Token: 0x04007126 RID: 28966
		private static readonly System.IntPtr NativeFieldInfoPtr_lerping;

		// Token: 0x04007127 RID: 28967
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04007128 RID: 28968
		private static readonly System.IntPtr NativeMethodInfoPtr_LerpNote_Private_IEnumerator_Transform_0;

		// Token: 0x04007129 RID: 28969
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C24 RID: 3108
		[ObfuscatedName("ScheduleOne.ObjectScripts.CashCounter+<LerpNote>d__10")]
		public sealed class _LerpNote_d__10 : Il2CppSystem.Object
		{
			// Token: 0x0600E3A6 RID: 58278 RVA: 0x0035D838 File Offset: 0x0035BA38
			// Note: this type is marked as 'beforefieldinit'.
			static _LerpNote_d__10()
			{
				Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "<LerpNote>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr);
				CashCounter._LerpNote_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, "<>1__state");
				CashCounter._LerpNote_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, "<>2__current");
				CashCounter._LerpNote_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, "<>4__this");
				CashCounter._LerpNote_d__10.NativeFieldInfoPtr_note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, "note");
				CashCounter._LerpNote_d__10.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, "<i>5__2");
				CashCounter._LerpNote_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, 100684031);
				CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, 100684032);
				CashCounter._LerpNote_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, 100684033);
				CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, 100684034);
				CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, 100684035);
				CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, 100684036);
			}

			// Token: 0x0600E3A7 RID: 58279 RVA: 0x0035D940 File Offset: 0x0035BB40
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LerpNote_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter._LerpNote_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E3A8 RID: 58280 RVA: 0x0035D988 File Offset: 0x0035BB88
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E3A9 RID: 58281 RVA: 0x0035D9BC File Offset: 0x0035BBBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294436, XrefRangeEnd = 294460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CashCounter._LerpNote_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x1700463F RID: 17983
			// (get) Token: 0x0600E3AA RID: 58282 RVA: 0x0035D9F8 File Offset: 0x0035BBF8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E3AB RID: 58283 RVA: 0x0035DA38 File Offset: 0x0035BC38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294460, XrefRangeEnd = 294465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004640 RID: 17984
			// (get) Token: 0x0600E3AC RID: 58284 RVA: 0x0035DA6C File Offset: 0x0035BC6C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E3AD RID: 58285 RVA: 0x0006EA70 File Offset: 0x0006CC70
			public _LerpNote_d__10(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700463A RID: 17978
			// (get) Token: 0x0600E3AE RID: 58286 RVA: 0x0035DAAC File Offset: 0x0035BCAC
			// (set) Token: 0x0600E3AF RID: 58287 RVA: 0x0006EA79 File Offset: 0x0006CC79
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700463B RID: 17979
			// (get) Token: 0x0600E3B0 RID: 58288 RVA: 0x0035DAD4 File Offset: 0x0035BCD4
			// (set) Token: 0x0600E3B1 RID: 58289 RVA: 0x0006EA94 File Offset: 0x0006CC94
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700463C RID: 17980
			// (get) Token: 0x0600E3B2 RID: 58290 RVA: 0x0035DB04 File Offset: 0x0035BD04
			// (set) Token: 0x0600E3B3 RID: 58291 RVA: 0x0006EAB3 File Offset: 0x0006CCB3
			public unsafe CashCounter __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashCounter>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700463D RID: 17981
			// (get) Token: 0x0600E3B4 RID: 58292 RVA: 0x0035DB34 File Offset: 0x0035BD34
			// (set) Token: 0x0600E3B5 RID: 58293 RVA: 0x0006EAD2 File Offset: 0x0006CCD2
			public unsafe Transform note
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr_note);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr_note), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700463E RID: 17982
			// (get) Token: 0x0600E3B6 RID: 58294 RVA: 0x0035DB64 File Offset: 0x0035BD64
			// (set) Token: 0x0600E3B7 RID: 58295 RVA: 0x0006EAF1 File Offset: 0x0006CCF1
			public unsafe float _i_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x0400987A RID: 39034
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400987B RID: 39035
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400987C RID: 39036
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400987D RID: 39037
			private static readonly System.IntPtr NativeFieldInfoPtr_note;

			// Token: 0x0400987E RID: 39038
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x0400987F RID: 39039
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009880 RID: 39040
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009881 RID: 39041
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009882 RID: 39042
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009883 RID: 39043
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009884 RID: 39044
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
