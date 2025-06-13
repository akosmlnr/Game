using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000488 RID: 1160
	public class PlayerSingleton<T> : MonoBehaviour where T : PlayerSingleton<T>
	{
		// Token: 0x0600639B RID: 25499 RVA: 0x001C7A38 File Offset: 0x001C5C38
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerSingleton()
		{
			Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PlayerSingleton`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr);
			PlayerSingleton<T>.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, "instance");
			PlayerSingleton<T>.NativeMethodInfoPtr_get_InstanceExists_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, 100676042);
			PlayerSingleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, 100676043);
			PlayerSingleton<T>.NativeMethodInfoPtr_set_Instance_Protected_Static_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, 100676044);
			PlayerSingleton<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, 100676045);
			PlayerSingleton<T>.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, 100676046);
			PlayerSingleton<T>.NativeMethodInfoPtr_OnStartClient_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, 100676047);
			PlayerSingleton<T>.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, 100676048);
			PlayerSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, 100676049);
		}

		// Token: 0x17001DC4 RID: 7620
		// (get) Token: 0x0600639C RID: 25500 RVA: 0x001C7B58 File Offset: 0x001C5D58
		public unsafe static bool InstanceExists
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 205644, RefRangeEnd = 205718, XrefRangeStart = 205638, XrefRangeEnd = 205644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerSingleton<T>.NativeMethodInfoPtr_get_InstanceExists_Public_Static_get_Boolean_0, 0, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001DC5 RID: 7621
		// (get) Token: 0x0600639D RID: 25501 RVA: 0x001C7B88 File Offset: 0x001C5D88
		// (set) Token: 0x0600639E RID: 25502 RVA: 0x001C7BB8 File Offset: 0x001C5DB8
		public unsafe static T Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(PlayerSingleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0, 0, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
			}
			[CallerCount(238)]
			[CachedScanResults(RefRangeStart = 204410, RefRangeEnd = 204648, XrefRangeStart = 204410, XrefRangeEnd = 204648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				ref System.IntPtr ptr2 = ref *ptr;
				System.IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				System.IntPtr returnedException;
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PlayerSingleton<T>.NativeMethodInfoPtr_set_Instance_Protected_Static_set_Void_T_0, 0, (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600639F RID: 25503 RVA: 0x001C7C24 File Offset: 0x001C5E24
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 205718, RefRangeEnd = 205750, XrefRangeStart = 205718, XrefRangeEnd = 205718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerSingleton<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063A0 RID: 25504 RVA: 0x001C7C60 File Offset: 0x001C5E60
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerSingleton<T>.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063A1 RID: 25505 RVA: 0x001C7C9C File Offset: 0x001C5E9C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 205786, RefRangeEnd = 205792, XrefRangeStart = 205750, XrefRangeEnd = 205786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnStartClient(bool IsOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref IsOwner;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerSingleton<T>.NativeMethodInfoPtr_OnStartClient_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063A2 RID: 25506 RVA: 0x001C7CE8 File Offset: 0x001C5EE8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 205798, RefRangeEnd = 205803, XrefRangeStart = 205792, XrefRangeEnd = 205798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerSingleton<T>.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063A3 RID: 25507 RVA: 0x001C7D24 File Offset: 0x001C5F24
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerSingleton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063A4 RID: 25508 RVA: 0x0002EDC9 File Offset: 0x0002CFC9
		public PlayerSingleton(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DC3 RID: 7619
		// (get) Token: 0x060063A5 RID: 25509 RVA: 0x001C7D60 File Offset: 0x001C5F60
		// (set) Token: 0x060063A6 RID: 25510 RVA: 0x001C7D84 File Offset: 0x001C5F84
		public unsafe static T instance
		{
			get
			{
				System.IntPtr objectPointer;
				IL2CPP.il2cpp_field_static_get_value(PlayerSingleton<T>.NativeFieldInfoPtr_instance, (void*)(&objectPointer));
				return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
			}
			set
			{
				System.IntPtr nativeFieldInfoPtr_instance = PlayerSingleton<T>.NativeFieldInfoPtr_instance;
				T value2;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr = value2 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
						if (ref ptr != null)
						{
							value2 = ref ptr;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr)))
							{
								value2 = IL2CPP.il2cpp_object_unbox(ref ptr);
							}
						}
					}
					else
					{
						value2 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					value2 = ref value;
				}
				IL2CPP.il2cpp_field_static_set_value(nativeFieldInfoPtr_instance, (void*)(&value2));
			}
		}

		// Token: 0x040043F3 RID: 17395
		private static readonly System.IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x040043F4 RID: 17396
		private static readonly System.IntPtr NativeMethodInfoPtr_get_InstanceExists_Public_Static_get_Boolean_0;

		// Token: 0x040043F5 RID: 17397
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0;

		// Token: 0x040043F6 RID: 17398
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Instance_Protected_Static_set_Void_T_0;

		// Token: 0x040043F7 RID: 17399
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040043F8 RID: 17400
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040043F9 RID: 17401
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040043FA RID: 17402
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x040043FB RID: 17403
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
