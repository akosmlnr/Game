using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Noise
{
	// Token: 0x0200038A RID: 906
	public class Listener : MonoBehaviour
	{
		// Token: 0x060045D2 RID: 17874 RVA: 0x0015A6F0 File Offset: 0x001588F0
		// Note: this type is marked as 'beforefieldinit'.
		static Listener()
		{
			Il2CppClassPointerStore<Listener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Noise", "Listener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Listener>.NativeClassPtr);
			Listener.NativeFieldInfoPtr_listeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Listener>.NativeClassPtr, "listeners");
			Listener.NativeFieldInfoPtr_Sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Listener>.NativeClassPtr, "Sensitivity");
			Listener.NativeFieldInfoPtr_HearingOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Listener>.NativeClassPtr, "HearingOrigin");
			Listener.NativeFieldInfoPtr__SquaredHearingRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Listener>.NativeClassPtr, "<SquaredHearingRange>k__BackingField");
			Listener.NativeFieldInfoPtr_onNoiseHeard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Listener>.NativeClassPtr, "onNoiseHeard");
			Listener.NativeMethodInfoPtr_get_SquaredHearingRange_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100671904);
			Listener.NativeMethodInfoPtr_set_SquaredHearingRange_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100671905);
			Listener.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100671906);
			Listener.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100671907);
			Listener.NativeMethodInfoPtr_OnDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100671908);
			Listener.NativeMethodInfoPtr_Notify_Public_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100671909);
			Listener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100671910);
		}

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x060045D3 RID: 17875 RVA: 0x0015A810 File Offset: 0x00158A10
		// (set) Token: 0x060045D4 RID: 17876 RVA: 0x0015A84C File Offset: 0x00158A4C
		public unsafe float SquaredHearingRange
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31486, RefRangeEnd = 31487, XrefRangeStart = 31486, XrefRangeEnd = 31487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr_get_SquaredHearingRange_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 31487, RefRangeEnd = 31489, XrefRangeStart = 31487, XrefRangeEnd = 31489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr_set_SquaredHearingRange_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060045D5 RID: 17877 RVA: 0x0015A88C File Offset: 0x00158A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159782, XrefRangeEnd = 159789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060045D6 RID: 17878 RVA: 0x0015A8C0 File Offset: 0x00158AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159789, XrefRangeEnd = 159802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060045D7 RID: 17879 RVA: 0x0015A8F4 File Offset: 0x00158AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159802, XrefRangeEnd = 159810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr_OnDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060045D8 RID: 17880 RVA: 0x0015A928 File Offset: 0x00158B28
		[CallerCount(0)]
		public unsafe void Notify(NoiseEvent nEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(nEvent);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr_Notify_Public_Void_NoiseEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060045D9 RID: 17881 RVA: 0x0015A96C File Offset: 0x00158B6C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 77482, RefRangeEnd = 77486, XrefRangeStart = 77482, XrefRangeEnd = 77486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Listener() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Listener>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060045DA RID: 17882 RVA: 0x00021E61 File Offset: 0x00020061
		public Listener(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x060045DB RID: 17883 RVA: 0x0015A9A8 File Offset: 0x00158BA8
		// (set) Token: 0x060045DC RID: 17884 RVA: 0x00021E6A File Offset: 0x0002006A
		public unsafe static List<Listener> listeners
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Listener.NativeFieldInfoPtr_listeners, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Listener>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Listener.NativeFieldInfoPtr_listeners, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x060045DD RID: 17885 RVA: 0x0015A9D0 File Offset: 0x00158BD0
		// (set) Token: 0x060045DE RID: 17886 RVA: 0x00021E7C File Offset: 0x0002007C
		public unsafe float Sensitivity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr_Sensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr_Sensitivity)) = value;
			}
		}

		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x060045DF RID: 17887 RVA: 0x0015A9F8 File Offset: 0x00158BF8
		// (set) Token: 0x060045E0 RID: 17888 RVA: 0x00021E97 File Offset: 0x00020097
		public unsafe Transform HearingOrigin
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr_HearingOrigin);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr_HearingOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x060045E1 RID: 17889 RVA: 0x0015AA28 File Offset: 0x00158C28
		// (set) Token: 0x060045E2 RID: 17890 RVA: 0x00021EB6 File Offset: 0x000200B6
		public unsafe float _SquaredHearingRange_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr__SquaredHearingRange_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr__SquaredHearingRange_k__BackingField)) = value;
			}
		}

		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x060045E3 RID: 17891 RVA: 0x0015AA50 File Offset: 0x00158C50
		// (set) Token: 0x060045E4 RID: 17892 RVA: 0x00021ED1 File Offset: 0x000200D1
		public unsafe Listener.HearingEvent onNoiseHeard
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr_onNoiseHeard);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Listener.HearingEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr_onNoiseHeard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002EBC RID: 11964
		private static readonly System.IntPtr NativeFieldInfoPtr_listeners;

		// Token: 0x04002EBD RID: 11965
		private static readonly System.IntPtr NativeFieldInfoPtr_Sensitivity;

		// Token: 0x04002EBE RID: 11966
		private static readonly System.IntPtr NativeFieldInfoPtr_HearingOrigin;

		// Token: 0x04002EBF RID: 11967
		private static readonly System.IntPtr NativeFieldInfoPtr__SquaredHearingRange_k__BackingField;

		// Token: 0x04002EC0 RID: 11968
		private static readonly System.IntPtr NativeFieldInfoPtr_onNoiseHeard;

		// Token: 0x04002EC1 RID: 11969
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SquaredHearingRange_Public_get_Single_0;

		// Token: 0x04002EC2 RID: 11970
		private static readonly System.IntPtr NativeMethodInfoPtr_set_SquaredHearingRange_Protected_set_Void_Single_0;

		// Token: 0x04002EC3 RID: 11971
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04002EC4 RID: 11972
		private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x04002EC5 RID: 11973
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Public_Void_0;

		// Token: 0x04002EC6 RID: 11974
		private static readonly System.IntPtr NativeMethodInfoPtr_Notify_Public_Void_NoiseEvent_0;

		// Token: 0x04002EC7 RID: 11975
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009B2 RID: 2482
		public sealed class HearingEvent : Il2CppSystem.MulticastDelegate
		{
			// Token: 0x0600CE57 RID: 52823 RVA: 0x003214B0 File Offset: 0x0031F6B0
			// Note: this type is marked as 'beforefieldinit'.
			static HearingEvent()
			{
				Il2CppClassPointerStore<Listener.HearingEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Listener>.NativeClassPtr, "HearingEvent");
				Listener.HearingEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener.HearingEvent>.NativeClassPtr, 100671912);
				Listener.HearingEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener.HearingEvent>.NativeClassPtr, 100671913);
				Listener.HearingEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NoiseEvent_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener.HearingEvent>.NativeClassPtr, 100671914);
				Listener.HearingEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener.HearingEvent>.NativeClassPtr, 100671915);
			}

			// Token: 0x0600CE58 RID: 52824 RVA: 0x00321524 File Offset: 0x0031F724
			[CallerCount(500)]
			[CachedScanResults(RefRangeStart = 85002, RefRangeEnd = 85502, XrefRangeStart = 85002, XrefRangeEnd = 85502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HearingEvent(Il2CppSystem.Object @object, System.IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Listener.HearingEvent>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref method;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.HearingEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CE59 RID: 52825 RVA: 0x00321580 File Offset: 0x0031F780
			[CallerCount(0)]
			public unsafe void Invoke(NoiseEvent nEvent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nEvent);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.HearingEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_NoiseEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CE5A RID: 52826 RVA: 0x003215C4 File Offset: 0x0031F7C4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 77936, RefRangeEnd = 77937, XrefRangeStart = 77936, XrefRangeEnd = 77937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppSystem.IAsyncResult BeginInvoke(NoiseEvent nEvent, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nEvent);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.HearingEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NoiseEvent_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
			}

			// Token: 0x0600CE5B RID: 52827 RVA: 0x00321638 File Offset: 0x0031F838
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.HearingEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CE5C RID: 52828 RVA: 0x000640CE File Offset: 0x000622CE
			public HearingEvent(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600CE5D RID: 52829 RVA: 0x000640D7 File Offset: 0x000622D7
			public static implicit operator Listener.HearingEvent(System.Action<NoiseEvent> A_0)
			{
				return DelegateSupport.ConvertDelegate<Listener.HearingEvent>(A_0);
			}

			// Token: 0x0600CE5E RID: 52830 RVA: 0x000640DF File Offset: 0x000622DF
			public static Listener.HearingEvent operator +(Listener.HearingEvent A_0, Listener.HearingEvent A_1)
			{
				return Il2CppSystem.Delegate.Combine(A_0, A_1).Cast<Listener.HearingEvent>();
			}

			// Token: 0x0600CE5F RID: 52831 RVA: 0x000640ED File Offset: 0x000622ED
			public static Listener.HearingEvent operator -(Listener.HearingEvent A_0, Listener.HearingEvent A_1)
			{
				Il2CppSystem.Delegate result;
				Il2CppSystem.Delegate @delegate = result = Il2CppSystem.Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Listener.HearingEvent>();
				}
				return result;
			}

			// Token: 0x04008BB6 RID: 35766
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008BB7 RID: 35767
			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_NoiseEvent_0;

			// Token: 0x04008BB8 RID: 35768
			private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NoiseEvent_AsyncCallback_Object_0;

			// Token: 0x04008BB9 RID: 35769
			private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
